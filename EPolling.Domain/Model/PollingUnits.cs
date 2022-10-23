using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Domain.Model
{
    public class PollingUnits
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public int LGAId { get; set; }
        public int WardId { get; set; }
        public string? PollingUnit { get; set; }
    }
}
