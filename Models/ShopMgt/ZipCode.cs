using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ZipCode
    {
        public string Zipcode1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCodeId { get; set; }
        public int RecordVersion { get; set; }
    }
}
