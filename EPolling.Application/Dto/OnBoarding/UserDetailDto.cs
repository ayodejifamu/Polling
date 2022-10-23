using EPolling.Application.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Application.Dto.OnBoarding
{
    public class UserDetailDto
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]

        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]

        public DateTime DOB { get; set; }

        [Display(Name = "Select State")]

        public State State { get; set; }

        [Display(Name = "Select Polling Unit")]

        public PollingUnit PollingUnit { get; set; }

        [Display(Name = "PVC Number")]
        public string PVC { get; set; }
    }
}
