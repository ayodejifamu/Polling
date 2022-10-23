using EPolling.Persistence.Repository.Common;
using EPolling.Domain.Model;
using EPolling.Application.Interface.Data;
using EPolling.Persistence.AppDbContext;

namespace EPolling.Persistence.Repository.Data
{
    public class LgaRepository : GenericRepository<LGAs>, ILgaRepository
    {
        public LgaRepository(PollingIdentityDbContext context) : base(context)
        {

        }
    }
}