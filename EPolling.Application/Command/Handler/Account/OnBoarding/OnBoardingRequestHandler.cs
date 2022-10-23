using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediatR;
using AutoMapper;
using System.Threading.Tasks;
using EPolling.Application.Interface.Identity;
using EPolling.Application.Exceptions;
using EPolling.Domain.Model;
using EPolling.Application.Response;
using System.Net;
using EPolling.Application.Command.Handler.Account.OnBoarding;

namespace EPolling.Application.Handler.Command.OnBoarding
{
    public class OnBoardingRequestHandler : IRequestHandler<OnBoardingRequest, BaseResponse<object>>
    {
        private readonly IMediator _mediator;
        private readonly IOnBoardingRepository _repo;
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;

        public OnBoardingRequestHandler(IMediator mediator, IOnBoardingRepository repo,
            IAuthService authService, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
            _repo = repo;
            _authService = authService;
        }

        public async Task<BaseResponse<object>> Handle(OnBoardingRequest command, CancellationToken cancellationToken)
        {
            var resp = new BaseResponse<object>();
            //Validate UserInput
            var validate = new OnBoardingValidator();
            var validateResult = await validate.ValidateAsync(command.userDetailDto);

            if (validateResult.IsValid == false)
            {
                var errors = new ValidationException(validateResult).Errors;
                resp = resp.HandleResponse(HttpStatusCode.BadRequest, errors, true);
                return resp;
            }

            bool checkId = await _authService.CheckUserId(command.UserId);
            if (checkId == false)
            {

                var error = new InternalServerException(nameof(OnBoardingRequest), command.UserId);
                resp = resp.HandleResponse(HttpStatusCode.InternalServerError, error.Message, true);
                return resp;
            }

            var mapUser = _mapper.Map<UserDetail>(command.userDetailDto);
            mapUser.UserId = command.UserId;
            var data = await _repo.AddAsync(mapUser);
            await _repo.SaveAsync();
            resp = resp.HandleResponse(HttpStatusCode.OK, command.UserId, true);
            return resp;

        }
    }
}
