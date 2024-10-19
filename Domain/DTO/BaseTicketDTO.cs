using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class BaseTicketDTO
    {

        public int Id {  get; set; }
        public string Description { get; set; }

        public TicketStatus Status { get; set; }

    }
}
