using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Entities
{
    public class Account
    {
        public string Id { get; set; }

        public string Nickname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime RegestrationDate { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public List<Message> Messages { get; set; } = new List<Message>();
    }
}
