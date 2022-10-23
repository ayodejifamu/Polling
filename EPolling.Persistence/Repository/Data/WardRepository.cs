using EPolling.Persistence.Repository.Common;
using EPolling.Domain.Model;
using EPolling.Application.Interface.Data;
using EPolling.Persistence.AppDbContext;

namespace EPolling.Persistence.Repository.Data
{
    public class WardRepository : GenericRepository<Wards>, IWardRepository
    {
        public WardRepository(PollingIdentityDbContext context): base(context)
        {
            
        }
    }
}