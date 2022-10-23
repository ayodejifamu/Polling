using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Application.Response
{
    public class APIResponseData
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public bool Status { get; set; }  
        public object Data { get; set; }

    }

    public class APIResponseData<T> : APIResponseData
    {
        public T Data { get; set; }
        
    }
}
