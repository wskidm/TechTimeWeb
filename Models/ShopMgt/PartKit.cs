using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PartKit
    {
        public PartKit()
        {
            CannedJobPartKitSequence = new HashSet<CannedJobPartKitSequence>();
            Part = new HashSet<Part>();
            PartKitParts = new HashSet<PartKitParts>();
        }

        public int PartKitId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? ListPrice { get; set; }
        public bool IsTaxable { get; set; }
        public int? CategoryId { get; set; }
        public int? AccountClassId { get; set; }
        public bool IsBundled { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public AccountClass AccountClass { get; set; }
        public Category Category { get; set; }
        public ICollection<CannedJobPartKitSequence> CannedJobPartKitSequence { get; set; }
        public ICollection<Part> Part { get; set; }
        public ICollection<PartKitParts> PartKitParts { get; set; }
    }
}
