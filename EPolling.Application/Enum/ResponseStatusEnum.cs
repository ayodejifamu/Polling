using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Application.Enum
{
    public enum ResponseStatusEnum
    {
        OK = 200,
        CREATED = 201,
        ACCEPTED = 202,
        NO_CONTENT = 204,
        BAD_REQUEST = 400,
        UNAUTHORIZED = 401,
        FORBIDDEN = 403,
        NOT_FOUND = 404,
        REQUEST_TIMEOUT = 408,
        CONFLICT = 409,
        SERVER_ERROR = 500
    }
}
