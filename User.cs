using System;
using System.Collections.Generic;

namespace AgendaConsoleApp
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public IList<Role> Roles { get; set; }
    }
}