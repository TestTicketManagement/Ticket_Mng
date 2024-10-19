using Domain.DTO;
using Domain.Models;
using Infrastructure.Data;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class TicketRepository : ITicket
    {
        private readonly DataContext _Context;
        public TicketRepository(DataContext Context) { _Context = Context; }


        private async Task<Ticket> FindTicketById(int id) =>
           await _Context.Tickets.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<GeneralResponse> AddTicket(AddTicketDTO ticket)
        {
            var Ticket = await FindTicketById(ticket.Id);
            if (Ticket is not null) return new GeneralResponse(false, "Ticket Id Already Exist");
            _Context.Tickets.Add(ticket.Adapt(new Ticket()));
            await _Context.SaveChangesAsync();
            return new GeneralResponse(true,"Ticket Added Success");
        }

        public async Task<GeneralResponse> DeleteTicket(int ticketId)
        {
            var Ticket = await FindTicketById(ticketId);
            if (Ticket == null) return new GeneralResponse(false,"Ticket Not Found");

            _Context.Tickets.Remove(Ticket);
            await _Context.SaveChangesAsync();
            return new GeneralResponse(true, "Ticket deleted");
        }

        public async Task<GetTicketDTO> GetTicket(int ticketId)
        {
            
            var ticket = await FindTicketById(ticketId);

            var ticketDto = new GetTicketDTO
            {
                Id = ticket.Id,
                Description = ticket.Description,
                Status = ticket.Status.ToString(),  
                CreationDate = ticket.CreationDate
            };

            return ticketDto!;
        }

        public async Task<List<GetTicketDTO>> getTickets()
        {
            var listTickets = await _Context.Tickets.ToListAsync();

            var ticketDtos = listTickets.Select(ticket => new GetTicketDTO
            {
                Id = ticket.Id,
                Description = ticket.Description,
                Status = ticket.Status.ToString(),  
                CreationDate = ticket.CreationDate
            }).ToList();

            return ticketDtos;
        }

        public async Task<GeneralResponse> UpdateTicket(UpdateTicketDTO ticket)
        {
            var Ticket = await FindTicketById(ticket.Id);
            if (Ticket is null) return new GeneralResponse(false,"Ticket Not Found");
            _Context.Entry(Ticket).State = EntityState.Detached;
            _Context.Tickets.Update(ticket.Adapt(new Ticket()));
            await _Context.SaveChangesAsync();
            return new GeneralResponse(true,"Ticket Updated");
        }
    }
}
