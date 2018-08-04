using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class SpecialPackageCategory
    {
        public SpecialPackageCategory()
        {
            SpecialPackage = new HashSet<SpecialPackage>();
        }

        public int SpecialPackageCategoryId { get; set; }
        public int CategoryOrdinal { get; set; }
        public int SpecialPackageTypeId { get; set; }
        public string CategoryDescription { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public SpecialPackageType SpecialPackageType { get; set; }
        public ICollection<SpecialPackage> SpecialPackage { get; set; }
    }
}
