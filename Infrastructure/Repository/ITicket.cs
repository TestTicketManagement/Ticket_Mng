using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface ITicket
    {
        Task<GeneralResponse> AddTicket(AddTicketDTO ticket);

        Task<GeneralResponse> UpdateTicket(UpdateTicketDTO ticket);

        Task<GeneralResponse> DeleteTicket(int ticketId);

        Task<GetTicketDTO> GetTicket(int ticketId);

        Task<List<GetTicketDTO>> getTickets();
    }
}
