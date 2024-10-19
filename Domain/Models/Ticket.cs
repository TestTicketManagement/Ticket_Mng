using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Ticket
    {
        public int id {  get; set; }

        public string description { get; set; }

        public TicketStatus status { get; set; }

        public DateTime CreationDate { get; set; }
    }

    public enum TicketStatus
    {
        Open,
        Closed
    }
}
