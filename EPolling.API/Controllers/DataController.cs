using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EPolling.Application.Dto.Data;
using EPolling.Application.Interface.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using EPolling.Application.Command.Handler.Data.AddPollingUnit;

namespace EPolling.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IStateRepository _state;
        private readonly IWardRepository _ward;
        private readonly ILgaRepository _lga;
        private readonly IPollingUnitRepository _poll;

        public DataController(IStateRepository state, IWardRepository ward, ILgaRepository lga,IPollingUnitRepository poll, IMediator mediator)
        {
            _state = state;
            _ward = ward;
            _lga = lga;
            _mediator = mediator;
            _poll = poll;
        }

        [HttpGet("GetAllState")]
        public async Task<IActionResult> getAllState()
        {
            return Ok(await _state.GetAllAsync());
        }

        [HttpGet("GetStateById")]
        public async Task<IActionResult> GetStateById(int Id)
        {
            var data = await _state.GetbyIdAsync(Id.ToString());
            return Ok(data);
        }

        [HttpGet("getAllLocalGov")]
        public async Task<IActionResult> getAllLocalGov()
        {

            return Ok(await _lga.GetAllAsync());
        }

        [HttpGet("GetLGAById")]
        public async Task<IActionResult> GetLGAById(int Id)
        {
            var data = await _lga.GetbyIdAsync(Id);
            return Ok(data);
        }

        [HttpGet("getAllWards")]
        public async Task<IActionResult> getAllWards()
        {
            return Ok(await _ward.GetAllAsync());
        }

        [HttpGet("GetWardById")]
        public async Task<IActionResult> GetWardById(int Id)
        {
            var data = await _ward.GetbyIdAsync(Id);
            return Ok(data);
        }

        [HttpGet("getAllPollingUnits")]
        public async Task<IActionResult> getAllPollingUnits()
        {
            var data = await _poll.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("GetPollingUnitById")]
        public async Task<IActionResult> GetPollingUnitById(int Id)
        {
            return Ok(await _poll.GetbyIdAsync(Id));
        }

        [HttpGet("GetAllCandidates")]
        public async Task<IActionResult> GetAllCandidates()
        {
            return Ok();
        }

        [HttpPost("AddPollingUnit")]
        public async Task<IActionResult> GetPollingUnitById([FromBody] PollingUnitDto pollingDto)
        {
            var data = await _mediator.Send(new AddPollingUnitRequest { pollingUnit = pollingDto });
            return Ok();
        }
    }
}
