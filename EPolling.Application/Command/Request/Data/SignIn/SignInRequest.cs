using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPolling.Application.Model.Identity;
using EPolling.Application.Response;
using MediatR;

namespace EPolling.Application.Command.Request.Data.SignIn
{
    public class SignInRequest : IRequest<BaseResponse<object>>
    {
        public LoginRequest loginRequest { get; set; }
    }
}
