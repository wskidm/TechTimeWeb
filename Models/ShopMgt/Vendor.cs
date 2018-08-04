using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Vendor
    {
        public Vendor()
        {
            InventoryTransaction = new HashSet<InventoryTransaction>();
            PartDescription = new HashSet<PartDescription>();
            PartItem = new HashSet<PartItem>();
            PartVendor = new HashSet<PartVendor>();
            Pomaster = new HashSet<Pomaster>();
            SubletItem = new HashSet<SubletItem>();
            VendorAddresses = new HashSet<VendorAddresses>();
            VendorLink = new HashSet<VendorLink>();
            VendorPhones = new HashSet<VendorPhones>();
        }

        public int VendorId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Contact { get; set; }
        public string Comment { get; set; }
        public decimal? Limit { get; set; }
        public string Terms { get; set; }
        public int? AcctClass { get; set; }
        public int? VendorTypeId { get; set; }
        public int? CatalogLinkId { get; set; }
        public bool Deleted { get; set; }
        public byte[] Timestamp { get; set; }
        public string EmailAddress { get; set; }
        public int RecordVersion { get; set; }

        public CatalogLink CatalogLink { get; set; }
        public VendorType VendorType { get; set; }
        public ICollection<InventoryTransaction> InventoryTransaction { get; set; }
        public ICollection<PartDescription> PartDescription { get; set; }
        public ICollection<PartItem> PartItem { get; set; }
        public ICollection<PartVendor> PartVendor { get; set; }
        public ICollection<Pomaster> Pomaster { get; set; }
        public ICollection<SubletItem> SubletItem { get; set; }
        public ICollection<VendorAddresses> VendorAddresses { get; set; }
        public ICollection<VendorLink> VendorLink { get; set; }
        public ICollection<VendorPhones> VendorPhones { get; set; }
    }
}
