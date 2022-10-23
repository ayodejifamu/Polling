using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Application.Response
{
    public class BaseResponse<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Data { get; set; }
        public bool Status { get; set; }

        public BaseResponse<T> HandleResponse(HttpStatusCode statusCode, T data, bool status)
        {
            return new BaseResponse<T>()
            {
                StatusCode = statusCode,
                Data = data,
                Status = status
            };
        }
    }
}
