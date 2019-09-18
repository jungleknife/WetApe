using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppWetApe.Models
{
    public class EventAttendee
    {
        public int ID { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string AttendeeId { get; set; }
        public ApplicationUser Attendee { get; set; }
    }
}
