using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Estimate
    {
        public int EstimateId { get; set; }
        public int RepairOrderId { get; set; }
        public decimal? EstimatedLaborCost { get; set; }
        public decimal? EstimatedPartsCost { get; set; }
        public decimal? EstimatedHours { get; set; }
        public decimal? EstimatedTaxAmount { get; set; }
        public decimal? EstimatedHazMatCost { get; set; }
        public decimal? EstShopSuppliesCost { get; set; }
        public decimal? EstimatedDiscount { get; set; }
        public byte[] Timestamp { get; set; }
        public decimal? EstimatedTireFeeCost { get; set; }
        public int RecordVersion { get; set; }

        public RepairOrder RepairOrder { get; set; }
    }
}
