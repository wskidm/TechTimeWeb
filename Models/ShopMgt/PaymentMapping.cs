using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PaymentMapping
    {
        public int PaymentMappingId { get; set; }
        public int PaymentId { get; set; }
        public int OriginalId { get; set; }
        public string OriginatingTableName { get; set; }
    }
}
