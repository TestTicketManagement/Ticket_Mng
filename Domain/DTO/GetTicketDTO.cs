using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class GetTicketDTO 
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
