using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using EPolling.Application.Interface.Data;
using EPolling.Domain.Model;

namespace EPolling.Application.Command.Handler.Data.AddPollingUnit
{
    public class AddPollingUnitHandler : IRequestHandler<AddPollingUnitRequest, bool>
    {
        private readonly IMapper _mapper;
        private readonly IPollingUnitRepository _poll;
        public AddPollingUnitHandler(IMapper mapper, IPollingUnitRepository poll)
        {
            _mapper = mapper;
            _poll = poll;
        }
        public async Task<bool> Handle(AddPollingUnitRequest request, CancellationToken cancellationToken)
        {
            //add a validation exception to check input

            if (request.pollingUnit == null)
            {
                return false;
            }

            var data = _mapper.Map<PollingUnits>(request.pollingUnit);
            await _poll.AddAsync(data);
            await _poll.SaveAsync();
            return true;
        }
    }
}
