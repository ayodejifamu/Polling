using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPolling.Application.Exceptions;
using EPolling.Application.Response;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Net;
using EPolling.Domain.Identity;
using EPolling.Application.Interface.Identity;
using EPolling.Application.Model.Identity;

namespace EPolling.Application.Command.Handler.Account.SignUp
{
    public class SignUpRequestHandler : IRequestHandler<SignupRequest, BaseResponse<object>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IAuthService _authService;
        public SignUpRequestHandler(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> sigInManager, IAuthService authService)
        {
            _userManager = userManager;
            _signInManager = sigInManager;
            _authService = authService;
        }
        public async Task<BaseResponse<object>> Handle(SignupRequest command, CancellationToken cancellationToken)
        {
            var resp = new BaseResponse<object>();
            var validator = new SignupValidator();
            var validationResult = await validator.ValidateAsync(command.registration);

            if (validationResult.IsValid == false)
            {
                var error = new ValidationException(validationResult).Errors;
                resp = resp.HandleResponse(HttpStatusCode.BadRequest, error, true);
                return resp;
            }


            var data = await _userManager.FindByEmailAsync(command.registration.Email);
            if (data != null)
            {
                var error = new BadRequestException($"{command.registration.Email} Already exist, Try Sign in").Message;
                resp = resp.HandleResponse(HttpStatusCode.BadRequest, error, true);
                return resp;
            }

            var hashers = new PasswordHasher<ApplicationUser>();
            ApplicationUser newUser = new ApplicationUser()
            {
                Email = command.registration.Email.ToString(),
                UserName = command.registration.Email.Split("@")[0]
            };
            var hashPass = hashers.HashPassword(newUser, command.registration.Password);


            var createUser = await _userManager.CreateAsync(newUser, command.registration.Password);
            if (!createUser.Succeeded)
            {
                resp = resp.HandleResponse(HttpStatusCode.BadRequest, createUser.Errors, true);
                return resp;
            }
            await _userManager.AddToRoleAsync(newUser, "Low");
            RegistrationResponse regResp = new() { UserId = newUser.Id };
            resp = resp.HandleResponse(HttpStatusCode.OK, regResp, true);
            return resp;
        }
    }
}
