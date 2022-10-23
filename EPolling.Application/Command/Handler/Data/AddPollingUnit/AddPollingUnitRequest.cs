using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPolling.Application.Dto.Data;
using MediatR;

namespace EPolling.Application.Command.Handler.Data.AddPollingUnit
{
    public class AddPollingUnitRequest : IRequest<bool>
    {
        public PollingUnitDto pollingUnit { get; set; }
    }
}
