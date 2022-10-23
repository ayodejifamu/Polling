using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Application.Exceptions
{
    public class InternalServerException : ApplicationException
    {
        public InternalServerException(string name, object key) : base($"{name} {key} was not Found")
        {

        }
    }
}
