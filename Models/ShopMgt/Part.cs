using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Part
    {
        public Part()
        {
            AlternatePartPrice = new HashSet<AlternatePartPrice>();
            AttachedPartPart = new HashSet<AttachedPart>();
            AttachedPartPartIdAttachedNavigation = new HashSet<AttachedPart>();
            InventoryPart = new HashSet<Inventory>();
            InventorySupercededByNavigation = new HashSet<Inventory>();
            InventoryTransaction = new HashSet<InventoryTransaction>();
            PartItem = new HashSet<PartItem>();
            PartKitParts = new HashSet<PartKitParts>();
            PartNumber = new HashSet<PartNumber>();
            PartTaxAssociation = new HashSet<PartTaxAssociation>();
            PartVendor = new HashSet<PartVendor>();
            Podetail = new HashSet<Podetail>();
        }

        public int PartId { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public bool TaxExempt { get; set; }
        public int? CategoryId { get; set; }
        public int? AccountClassId { get; set; }
        public string Comment { get; set; }
        public int? ManufacturerId { get; set; }
        public decimal ListPrice { get; set; }
        public bool UserEnteredPrice { get; set; }
        public int? KitId { get; set; }
        public bool IsMplgitem { get; set; }
        public bool IsChangedMplgitem { get; set; }
        public bool IsCore { get; set; }
        public decimal? CoreCost { get; set; }
        public decimal? CoreListPrice { get; set; }
        public int? PartFeeId { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] Timestamp { get; set; }
        public string Size { get; set; }
        public bool IsTire { get; set; }
        public int RecordVersion { get; set; }

        public AccountClass AccountClass { get; set; }
        public Category Category { get; set; }
        public PartKit Kit { get; set; }
        public PartManufacturer Manufacturer { get; set; }
        public PartFee PartFee { get; set; }
        public ICollection<AlternatePartPrice> AlternatePartPrice { get; set; }
        public ICollection<AttachedPart> AttachedPartPart { get; set; }
        public ICollection<AttachedPart> AttachedPartPartIdAttachedNavigation { get; set; }
        public ICollection<Inventory> InventoryPart { get; set; }
        public ICollection<Inventory> InventorySupercededByNavigation { get; set; }
        public ICollection<InventoryTransaction> InventoryTransaction { get; set; }
        public ICollection<PartItem> PartItem { get; set; }
        public ICollection<PartKitParts> PartKitParts { get; set; }
        public ICollection<PartNumber> PartNumber { get; set; }
        public ICollection<PartTaxAssociation> PartTaxAssociation { get; set; }
        public ICollection<PartVendor> PartVendor { get; set; }
        public ICollection<Podetail> Podetail { get; set; }
    }
}
