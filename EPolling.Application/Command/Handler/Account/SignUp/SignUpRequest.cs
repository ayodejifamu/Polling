using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPolling.Application.Model.Identity;
using EPolling.Application.Response;
using MediatR;

namespace EPolling.Application.Command.Handler.Account.SignUp
{
    public class SignupRequest : IRequest<BaseResponse<object>>
    {
        public RegistrationRequest registration { get; set; }
    }

}
