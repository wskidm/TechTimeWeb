using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PartItem
    {
        public int PartItemId { get; set; }
        public int LineItemId { get; set; }
        public int? PartDiscountDescriptionId { get; set; }
        public bool? IsUserEnteredUnitSale { get; set; }
        public bool? IsUserEnteredUnitCost { get; set; }
        public decimal Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? UnitList { get; set; }
        public decimal? UnitSale { get; set; }
        public decimal? UnitCost { get; set; }
        public string PartNo { get; set; }
        public int? PartId { get; set; }
        public bool? IsConfirmed { get; set; }
        public string VendorCode { get; set; }
        public int? VendorId { get; set; }
        public int? ManufacturerId { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? CommissionAmount { get; set; }
        public bool? IsCommitted { get; set; }
        public bool? IsQuantityConfirmed { get; set; }
        public decimal? ConfirmedQuantity { get; set; }
        public int? IsPartOrdered { get; set; }
        public bool? IsCore { get; set; }
        public bool? IsBundledKit { get; set; }
        public bool? IsMplgItem { get; set; }
        public bool? IsChangedMplgItem { get; set; }
        public string PartType { get; set; }
        public byte[] Timestamp { get; set; }
        public string Size { get; set; }
        public bool IsTire { get; set; }
        public int RecordVersion { get; set; }

        public LineItem LineItem { get; set; }
        public PartManufacturer Manufacturer { get; set; }
        public Part Part { get; set; }
        public PartDiscountDescription PartDiscountDescription { get; set; }
        public Vendor Vendor { get; set; }
    }
}
