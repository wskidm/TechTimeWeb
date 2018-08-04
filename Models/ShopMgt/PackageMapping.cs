using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PackageMapping
    {
        public int PackageMappingId { get; set; }
        public int PackageId { get; set; }
        public int OriginalId { get; set; }
        public string OriginatingTableName { get; set; }
    }
}
