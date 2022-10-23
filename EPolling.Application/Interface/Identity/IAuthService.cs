using EPolling.Application.Model.Identity;
using EPolling.Domain.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Application.Interface.Identity
{
    public interface IAuthService
    {
        Task<LoginResponse> SignIn(LoginRequest request);
        Task<RegistrationResponse> SignUp(RegistrationRequest request);
        Task<string> SignOut();
        Task<string> ResetPassword(string emailAddress, string newPassword);   
        Task<LoginResponse> GoogleSignIn();
        Task<bool> CheckUserId(string UserId);
        Task<JwtSecurityToken> GenerateToken(ApplicationUser applicationUser);


    }
}
