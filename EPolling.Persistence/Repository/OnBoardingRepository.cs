using EPolling.Application.Interface;
using EPolling.Application.Interface.Identity;
using EPolling.Domain.Model;
using EPolling.Persistence.AppDbContext;

namespace EPolling.Persistence.Repository.Common
{
    public class OnBoardingRepository : GenericRepository<UserDetail>, IOnBoardingRepository
    {
        public OnBoardingRepository(PollingIdentityDbContext context)
            :base(context)
        {
            
        }
    }
}