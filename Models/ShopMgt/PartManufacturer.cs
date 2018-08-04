using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PartManufacturer
    {
        public PartManufacturer()
        {
            Part = new HashSet<Part>();
            PartItem = new HashSet<PartItem>();
            PodetailAltMfg = new HashSet<Podetail>();
            PodetailMfg = new HashSet<Podetail>();
        }

        public int ManufacturerId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Part> Part { get; set; }
        public ICollection<PartItem> PartItem { get; set; }
        public ICollection<Podetail> PodetailAltMfg { get; set; }
        public ICollection<Podetail> PodetailMfg { get; set; }
    }
}
