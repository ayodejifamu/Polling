using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Application.Dto.Data
{
    public class PollingUnitDto
    {
        public int StateId { get; set; }
        public int LGAId { get; set; }
        public int WardId { get; set; }
        public string PollingUnitName { get; set; }
    }
}
