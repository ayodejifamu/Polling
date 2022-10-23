using System.Net;
using EPolling.Application.Interface.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using EPolling.Application.Dto.OnBoarding;
using EPolling.Application.Response;
using EPolling.Application.Model.Identity;
using EPolling.Application.Command.Handler.Account.SignUp;
using EPolling.Application.Command.Request.Data.SignIn;
using EPolling.Application.Command.Handler.Account.OnBoarding;

namespace EPolling.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]

    public class AccountController : BaseController
    {
        private readonly IAuthService _authService;
        private readonly IMediator _mediator;

        public AccountController(IAuthService authservice, IMediator mediator)
        {
            _authService = authservice;
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpGet("Ping")]
        public async Task<ActionResult<LoginResponse>> Ping()
        {
            return Ok(new { ResponseCode = HttpStatusCode.OK, ResponseMessage = "API Live" });
        }


        [AllowAnonymous]
        [HttpPost("SignUp")]
        [ProducesResponseType(typeof(BaseResponse<object>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BaseResponse<object>), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> SignUp([FromBody] RegistrationRequest request)
        {
            var resp = await _mediator.Send(new SignupRequest { registration = request });
            return HandleIActionResult(resp);
        }

        [AllowAnonymous]
        [HttpPost("SignIn")]
        [ProducesResponseType(typeof(BaseResponse<object>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BaseResponse<object>), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(BaseResponse<object>), (int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> SignIn([FromBody] LoginRequest request)
        {
            var resp = await _mediator.Send(new SignInRequest { loginRequest = request });
            return HandleIActionResult(resp);
        }

        [HttpPost("Signout")]
        [ProducesResponseTypeAttribute(typeof(string), 200)]
        public async Task<ActionResult> SignOut()
        {
            var result = await _authService.SignOut();
            return Ok(result);
        }

        [HttpPost("OnBoarding")]
        [ProducesResponseType(typeof(BaseResponse<object>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BaseResponse<object>), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(BaseResponse<object>), (int)HttpStatusCode.InternalServerError)]
        [Authorize]
        public async Task<IActionResult> OnBoarding([FromQuery] string userId, [FromBody] UserDetailDto userDetail)
        {
            var data = await _mediator.Send(new OnBoardingRequest { userDetailDto = userDetail, UserId = userId });
            return HandleIActionResult(data);
        }

        [HttpPost("GoogleLogin")]
        [AllowAnonymous]
        public async Task<LoginResponse> GoogleLogin()
        {
            return await _authService.GoogleSignIn();
        }

        [HttpPost("ResetPassword")]
        [AllowAnonymous]
        public async Task<string> ResetPassword([FromQuery] string emailAddress, [FromQuery] string newPassword)
        {
            return await _authService.ResetPassword(emailAddress, newPassword);
        }
    }
}
