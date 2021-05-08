using System;

namespace AgendaConsoleApp {
    class Event : Entity {
        public string Title { get; set; }
        public string Speaker { get; set; }
        public string Description { get; set; }
        public DateTime StartingDt { get; set; }
        public int Duration { get; set; }
        public DateTime EnrollmentDeadLineDt { get; set; }
        public string Url { get; set; }
        public string Banner { get; set; }
        public bool Active { get; set; }
        public int IdOrganizer { get; set; }
        public int IdCategory { get; set; }
    }
}