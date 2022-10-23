using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPolling.Domain.Common;

namespace EPolling.Domain.Model
{
    public class UserDetail : IEntityBase
    {
        public string Id {get; set;} = Guid.NewGuid().ToString();           
        public string UserId { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string State { get; set; }
        public string PollingUnit { get; set; }
        public string PVC { get; set; }
    }
}
