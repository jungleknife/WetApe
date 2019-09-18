using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppWetApe.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Level { get; set; }
        public int Price { get; set; }
        public int Capacity { get; set; }
        public DateTime Date { get; set; }

        public EventCategory EventCategory { get; set; }
        public Venue Venue { get; set; }
        public ApplicationUser Owner { get; set; }
        public ICollection<EventAttendee> Attendees { get; set; }

       
    }
}
