using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechTime.Models.TechTime
{
    public class Event
    {
        public int EventId { get; set; }

        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }

        public DateTime EventDateTime { get; set; }
        public string Note { get; set; }
        public int EmployeeId { get; set; }
        public int JobId { get; set; }
        public int JobRevision { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public int LastEditedId { get; set; }
    }
}
