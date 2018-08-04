using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PartKitMapping
    {
        public int PartKitMappingId { get; set; }
        public int PartKitId { get; set; }
        public int OriginalId { get; set; }
        public string OriginatingTableName { get; set; }
    }
}
