using System;
using System.Collections.Generic;

namespace AgendaConsoleApp
{
    public class Event : Entity
    {
        public string Title { get; set; }
        public User Speaker { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationInMinutes { get; set; }
        public DateTime EnrollmentDeadlineDate { get; set; }
        public string Url { get; set; }
        public string Banner { get; set; }
        public bool Active { get; set; }
        public User Organizer { get; set; }
        public Category Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}