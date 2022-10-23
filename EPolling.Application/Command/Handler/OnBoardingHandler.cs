using EPolling.Application.Dto.OnBoarding;
using EPolling.Application.Interface.Identity;
using AutoMapper;
using MediatR;
using EPolling.Domain.Model;

namespace EPolling.Application.Command.Handler
{

    public class OnBoardingCommand: IRequest<string>
    {
        public UserDetailDto userDetailDto {get; set;}

        public string UserId {get;set;}
    }

    public class OnBoardingHandler : IRequestHandler<OnBoardingCommand, string>
    {
        private readonly IOnBoardingRepository _repo;
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;
        public OnBoardingHandler(IOnBoardingRepository repo, IMapper mapper, IAuthService authservice)
        {
            _mapper = mapper;
            _repo = repo;
            _authService = authservice;
        }

        public async Task<string> Handle(OnBoardingCommand request, CancellationToken cancellationToken)
        {
            bool checkId = await _authService.CheckUserId(request.UserId);
            if (checkId == false)
            {
                throw new Exception($"User with the Id: {request.UserId} not found");
            }
            var mapUser = _mapper.Map<UserDetail>(request.userDetailDto);
            mapUser.UserId = request.UserId;
            var data = await _repo.AddAsync(mapUser);
            return request.UserId;
        }
    }

}