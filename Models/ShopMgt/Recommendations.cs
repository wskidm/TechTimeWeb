using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Recommendations
    {
        public int RecommendationId { get; set; }
        public int VehicleId { get; set; }
        public DateTime RecommendDate { get; set; }
        public string RecommendText { get; set; }
        public DateTime DateEntered { get; set; }
        public int? CategoryId { get; set; }
        public DateTime FollowUpDate { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Category Category { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
