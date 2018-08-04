using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CatalogLink
    {
        public CatalogLink()
        {
            CatalogVehicleLink = new HashSet<CatalogVehicleLink>();
            Vendor = new HashSet<Vendor>();
        }

        public int CatalogLinkId { get; set; }
        public string Name { get; set; }
        public byte[] Timestamp { get; set; }
        public string DisplayName { get; set; }
        public string InterfaceVersion { get; set; }
        public string AuthCode { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<CatalogVehicleLink> CatalogVehicleLink { get; set; }
        public ICollection<Vendor> Vendor { get; set; }
    }
}
