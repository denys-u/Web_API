using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Entities
{
    public class Role
    {
        public int Id { get; set; }

        public string RoleName { get; set; }

        public List<Account> Accounts { get; set; } = new List<Account>();
    }
}
