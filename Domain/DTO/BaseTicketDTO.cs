﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class BaseTicketDTO
    {
        [Required]
        public int Id {  get; set; }
        [Required]
        public string Description { get; set; }

        public TicketStatus Status { get; set; }

    }
}
