using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Nickname { get; set; }

        public DateTime RegestrationDate { get; set; }

        public virtual List<Message> Messages { get; set; } = new List<Message>();

    }
}
