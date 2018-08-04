using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class SpecialPackageType
    {
        public SpecialPackageType()
        {
            SpecialPackageCategory = new HashSet<SpecialPackageCategory>();
        }

        public int SpecialPackageTypeId { get; set; }
        public string SpecialPackageType1 { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<SpecialPackageCategory> SpecialPackageCategory { get; set; }
    }
}
