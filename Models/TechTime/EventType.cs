using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechTime.Models.TechTime
{
    public class EventType
    {
        public int EventTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int TimeTypeId { get; set; }
        public TimeType TimeType { get; set; }
    }
}
