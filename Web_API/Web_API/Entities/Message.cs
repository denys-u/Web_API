﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Entities
{
    public class Message
    {
        public int Id { get; set; }

        public DateTime DateOfTransmission { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }
    }
}
