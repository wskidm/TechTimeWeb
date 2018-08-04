using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Package
    {
        public Package()
        {
            PackageCommission = new HashSet<PackageCommission>();
            PackageItem = new HashSet<PackageItem>();
        }

        public int PackageId { get; set; }
        public int? CategoryId { get; set; }
        public int? AcctClassId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Sale { get; set; }
        public bool TaxAsPart { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Category Category { get; set; }
        public ICollection<PackageCommission> PackageCommission { get; set; }
        public ICollection<PackageItem> PackageItem { get; set; }
    }
}
