using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechTime.Models.TechTime
{
    public class TimeType
    {
        public int TimeTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int TrackTypeId { get; set; }
        public TrackType TrackType { get; set; }
    }
}
