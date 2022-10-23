using EPolling.Application.Enum;
using EPolling.Application.Interface.Identity;
using EPolling.Application.Model.Identity;
using EPolling.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Application.Repository.Identity
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly JwtSettings _jwtSettings;

        public AuthService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IOptions<JwtSettings> jwtSettings)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtSettings = jwtSettings.Value;
        }

        public async Task<LoginResponse> SignIn(LoginRequest request)
        {
            try
            {
                var data = await _userManager.FindByEmailAsync(request.Email);
                if (data == null)
                {
                    throw new Exception($"User with {request.Email} not Found");
                }


                var passwordData = await _signInManager.PasswordSignInAsync(data, request.Password, isPersistent: false, lockoutOnFailure: false);

                if (!passwordData.Succeeded)
                {
                    throw new Exception($"Incorrect Password for {request.Email}");
                }

                JwtSecurityToken token = await GenerateToken(data);
                LoginResponse resp = new()
                {
                    Email = data.Email,
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Id = data.Id
                };
                return resp;
            }
            catch (Exception ex)
            {

                throw new Exception($"Error Message: {ex}");
            }

        }

        public async Task<LoginResponse> GoogleSignIn()
        {
            var result = await _signInManager.GetExternalLoginInfoAsync();
            if (result is null)
            {
                throw new Exception($"Signin Failed");
            }

            var login = await _signInManager.ExternalLoginSignInAsync(result.LoginProvider, result.ProviderKey, isPersistent: false);

            if (login.Succeeded)
            {
                await _signInManager.UpdateExternalAuthenticationTokensAsync(result);
                var user = await _userManager.FindByEmailAsync(result.Principal.FindFirstValue(ClaimTypes.Email).FirstOrDefault().ToString());
                var loginINfo = await _userManager.AddLoginAsync(user, result);
                return new LoginResponse()
                {
                    Token = result.AuthenticationTokens.Select(x => x.Value).FirstOrDefault().ToString(),
                    Email = user.Email
                };
            }

            return new LoginResponse();
        }

        public async Task<string> ResetPassword(string emailAddress, string newPassword)
        {
            var user = await _userManager.FindByEmailAsync(emailAddress);
            if (user is null)
            {
                throw new Exception($"Invalid EmailAddress {emailAddress}");
            }
            //Send an Email with the Token and Link to add new Password Hash then Update the DB

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            return token;
        }

        public async Task<string> SignOut()
        {
            await _signInManager.SignOutAsync();
            return "Sign Out was Successful";
        }

        public async Task<RegistrationResponse> SignUp(RegistrationRequest request)
        {
            try
            {
                var data = await _userManager.FindByEmailAsync(request.Email);
                if (data != null)
                {
                    throw new Exception($"This {request.Email} already Exist");
                }
                var hashers = new PasswordHasher<ApplicationUser>();


                ApplicationUser newUser = new ApplicationUser()
                {
                    Email = request.Email.ToString(),
                    UserName = request.Email.Split("@")[0]
                };

                //var createUse = await _userManager.CreateAsync(newUser);    
                var createUser = await _userManager.CreateAsync(newUser, request.Password);
                if (!createUser.Succeeded)
                {
                    throw new Exception($"{createUser.Errors}");
                }
                await _userManager.AddToRoleAsync(newUser, "Low");
                return new RegistrationResponse { UserId = newUser.Id };
            }
            catch (System.Exception ex)
            {
                var r = new RegistrationResponse();
                r.UserId = ex.Message + ex.StackTrace;
                return r;
            }

        }


        public async Task<JwtSecurityToken> GenerateToken(ApplicationUser applicationUser)
        {
            var userClaims = await _userManager.GetClaimsAsync(applicationUser);
            var roles = await _userManager.GetRolesAsync(applicationUser);

            var rolesClaims = new List<Claim>();

            for (int i = 0; i < roles.Count; i++)
            {
                rolesClaims.Add(new Claim(ClaimTypes.Role, roles[i]));
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, applicationUser.Email),
                new Claim("UserId", applicationUser.Id)
            }.Union(userClaims).Union(rolesClaims);

            var symetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_jwtSettings.DurationInMinutes * 5),
                signingCredentials: signingCredentials);

            return jwtSecurityToken;
        }

        public async Task<bool> CheckUserId(string UserId)
        {
            var data = await _userManager.FindByIdAsync(UserId);
            if (data == null)
                return false;
            return true;
        }
    }
}
