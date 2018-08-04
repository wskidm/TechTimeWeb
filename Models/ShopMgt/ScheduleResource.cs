using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ScheduleResource
    {
        public ScheduleResource()
        {
            Schedule = new HashSet<Schedule>();
        }

        public int ResourceId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int ColorValue { get; set; }
        public bool IsDeleted { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string NickName { get; set; }
        public string Notes { get; set; }
        public string SerialNumber { get; set; }
        public string Size { get; set; }
        public string WarrantyInformation { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Schedule> Schedule { get; set; }
    }
}
