using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Application.Model.Identity
{
    public class JwtSettings
    {
        public int DurationInMinutes { get; set; }
        public string Token { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Key { get; set; }

    }
}
