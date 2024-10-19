using Domain.DTO;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ticket_Mng_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicket _ticketService;
        public TicketController( ITicket ticketService ) { _ticketService = ticketService; }

        //Add Ticket
        [HttpPost("add-ticket")]
        public async Task<ActionResult<GeneralResponse>> AddTicket(AddTicketDTO model)
        {
            if (!ModelState.IsValid)
                return BadRequest("Model is invalid");

            return Ok(await _ticketService.AddTicket(model));
        }

        //Update Ticket

        [HttpPut("update-ticket")]
        public async Task<ActionResult<GeneralResponse>> UpdateTicket(UpdateTicketDTO model)
        {
            if (!ModelState.IsValid)
                return BadRequest("Model is invalid");
            return Ok(await _ticketService.UpdateTicket(model));
        }

        //Delete
        [HttpDelete("delete-ticket/{id}")]
        public async Task<ActionResult<GeneralResponse>> DeleteTicket(int id)
        {

            return Ok(await _ticketService.DeleteTicket(id));
        }

        //get // single
        [HttpGet("get-ticket/{id}")]
        public async Task<ActionResult<GetTicketDTO>> GetTicket(int id)
        {
            return Ok(await _ticketService.GetTicket(id));
        }

        //get //list
        [HttpGet("get-tickets")]
        public async Task<ActionResult<IList<GetTicketDTO>>> GetTickets()
        {
            return Ok(await _ticketService.getTickets());
        }
    }
}
