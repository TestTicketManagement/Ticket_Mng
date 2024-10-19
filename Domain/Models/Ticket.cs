using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Ticket
    {
        public int Id {  get; set; }

        public string Description { get; set; }

        public TicketStatus Status { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;
    }

    public enum TicketStatus
    {
        Open = 0,
        Closed = 1
    }
}
