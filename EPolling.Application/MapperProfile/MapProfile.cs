using AutoMapper;
using EPolling.Application.Dto.Data;
using EPolling.Application.Dto.OnBoarding;
using EPolling.Application.Enum;
using EPolling.Domain.Model;

namespace EPolling.Application.MapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<UserDetail, UserDetailDto>().ReverseMap();
            CreateMap<PollingUnitDto, PollingUnits>().ReverseMap();
        }
    }
}