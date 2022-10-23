using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Application.Model.Identity
{
    public class LoginResponse
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
