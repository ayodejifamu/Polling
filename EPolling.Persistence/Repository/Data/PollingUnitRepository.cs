using EPolling.Persistence.Repository.Common;
using EPolling.Domain.Model;
using EPolling.Application.Interface.Data;
using EPolling.Persistence.AppDbContext;

namespace EPolling.Persistence.Repository.Data
{
    public class PollingUnitRepository : GenericRepository<PollingUnits>, IPollingUnitRepository
    {
        public PollingUnitRepository(PollingIdentityDbContext context) : base(context)
        {

        }
    }
}