using EPolling.Persistence.Repository.Common;
using EPolling.Domain.Model;
using EPolling.Application.Interface.Data;
using EPolling.Persistence.AppDbContext;

namespace EPolling.Persistence.Repository.Data
{
    public class StateRepository : GenericRepository<States>, IStateRepository
    {
        public StateRepository(PollingIdentityDbContext context) : base(context)
        {

        }
    }
}