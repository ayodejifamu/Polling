using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using System.Text;
using System.Threading.Tasks;
using EPolling.Application.Dto.OnBoarding;
using EPolling.Application.Response;

namespace EPolling.Application.Command.Handler.Account.OnBoarding
{
    public class OnBoardingRequest : IRequest<BaseResponse<object>>
    {
        public UserDetailDto userDetailDto { get; set; }
        public string UserId { get; set; }
    }
}
