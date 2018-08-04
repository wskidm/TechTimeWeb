using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ZipCodeAlternate
    {
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCodeAlternateId { get; set; }
        public int RecordVersion { get; set; }
    }
}
