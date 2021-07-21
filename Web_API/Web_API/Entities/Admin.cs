using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Entities
{
    public class Admin
    {
        public int Id { get; set; }

        public string Nickname { get; set; }

        public DateTime RegestrationDate { get; set; }
    }
}
