using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class SpecialPackage
    {
        public SpecialPackage()
        {
            SpecialPackageLineItemSequence = new HashSet<SpecialPackageLineItemSequence>();
        }

        public int SpecialPackageId { get; set; }
        public string Description { get; set; }
        public int SpecialPackageCategoryId { get; set; }
        public int SpecialPackageOrdinal { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public SpecialPackageCategory SpecialPackageCategory { get; set; }
        public ICollection<SpecialPackageLineItemSequence> SpecialPackageLineItemSequence { get; set; }
    }
}
