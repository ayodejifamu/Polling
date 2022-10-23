using EPolling.Application.Constant;
using EPolling.Application.Enum;
using EPolling.Application.Response;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mime;

namespace EPolling.API.Controllers
{
    [ApiController]
    [EnableCors(CorsPolicy.POLICY)]
    [Produces(MediaTypeNames.Application.Json)]
    public abstract class BaseController : ControllerBase
    {
        private ISender _mediator;
        protected ISender mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
        protected IActionResult HandleIActionResult(BaseResponse<object> response)
        {
            ObjectResult result;
            switch (response.StatusCode)
            {
                case (HttpStatusCode)ResponseStatusEnum.OK:
                    result = Ok(response);
                    break;
                case (HttpStatusCode)ResponseStatusEnum.CREATED:
                    result = StatusCode(StatusCodes.Status201Created, response);
                    break;
                case (HttpStatusCode)ResponseStatusEnum.ACCEPTED:
                    result = StatusCode(StatusCodes.Status202Accepted, response);
                    break;
                case (HttpStatusCode)ResponseStatusEnum.NO_CONTENT:
                    result = StatusCode(StatusCodes.Status204NoContent, response);
                    break;
                case (HttpStatusCode)ResponseStatusEnum.BAD_REQUEST:
                    result = BadRequest(response);
                    break;
                case (HttpStatusCode)ResponseStatusEnum.UNAUTHORIZED:
                    result = StatusCode(StatusCodes.Status401Unauthorized, response);
                    break;
                case (HttpStatusCode)ResponseStatusEnum.FORBIDDEN:
                    result = StatusCode(StatusCodes.Status403Forbidden, response);
                    break;
                case (HttpStatusCode)ResponseStatusEnum.CONFLICT:
                    result = StatusCode(StatusCodes.Status409Conflict, response);
                    break;
                default:
                    result = StatusCode(StatusCodes.Status500InternalServerError, response);
                    break;
            }
            return result;
        }
    }
}
