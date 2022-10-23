using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPolling.Application.Exceptions;
using EPolling.Application.Response;
using System.Net;
using MediatR;
using Microsoft.AspNetCore.Identity;
using EPolling.Domain.Identity;
using EPolling.Application.Interface.Identity;
using System.IdentityModel.Tokens.Jwt;
using EPolling.Application.Model.Identity;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EPolling.Application.Command.Request.Data.SignIn
{
    public class SignInRequestHandler : IRequestHandler<SignInRequest, BaseResponse<object>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IAuthService _authService;
        public SignInRequestHandler(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> sigInManager, IAuthService authService)
        {
            _userManager = userManager;
            _signInManager = sigInManager;
            _authService = authService;
        }

        public async Task<BaseResponse<object>> Handle(SignInRequest request, CancellationToken cancellationToken)
        {
            var resp = new BaseResponse<object>();
            var validator = new SignInValidator();

            var validationResult = await validator.ValidateAsync(request.loginRequest);
            if (validationResult.IsValid == false)
            {
                var error = new ValidationException(validationResult).Errors;
                resp = resp.HandleResponse(HttpStatusCode.BadRequest, error, true);
                return resp;
            }
            var data = await _userManager.FindByEmailAsync(request.loginRequest.Email);
            //var hashers = new PasswordHasher<ApplicationUser>();
            //var hashPass = hashers.HashPassword(data, request.loginRequest.Password);
            if (data == null)
            {
                var error = new NotFoundException(nameof(SignInRequest), request.loginRequest.Email).Message;
                resp = resp.HandleResponse(HttpStatusCode.NotFound, error, true);
                return resp;
            }

            var passwordData = await _signInManager.PasswordSignInAsync(data, request.loginRequest.Password,isPersistent:false, lockoutOnFailure: false);

            if (!passwordData.Succeeded)
            {
                var error = new BadRequestException($"Incorrect Password for {request.loginRequest.Email}").Message;
                resp = resp.HandleResponse(HttpStatusCode.BadRequest, error, true);
                return resp;
            }

            var token = await _authService.GenerateToken(data);
            LoginResponse loginResp = new()
            {
                Email = data.Email,
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Id = data.Id
            };
            resp = resp.HandleResponse(HttpStatusCode.OK, loginResp, true);
            return resp;
        }
    }
}
