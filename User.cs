using System.Collections.Generic;

namespace AgendaConsoleApp {
    class User : Entity {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IList<Role> Roles { get; set; }
        public IList<Event> EnrolledEvents { get; set; }
    }
}