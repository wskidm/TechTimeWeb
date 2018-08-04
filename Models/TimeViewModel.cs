using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechTime.Models
{
    public class TimeViewModel
    {
        public string message { get; set; }

        public int eventTypeId { get; set; }
        public string eventDateTime { get; set; }
        public string note { get; set; }
        public int jobId { get; set; }
        
        public List<SelectListItem> eventTypes { get; set; }
        public List<SelectListItem> jobTypes { get; set; }
    }
}
