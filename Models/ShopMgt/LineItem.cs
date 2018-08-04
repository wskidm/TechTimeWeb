using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class LineItem
    {
        public LineItem()
        {
            CannedJobLineItemSequence = new HashSet<CannedJobLineItemSequence>();
            LaborItem = new HashSet<LaborItem>();
            LineItemTaxes = new HashSet<LineItemTaxes>();
            LineItemTechs = new HashSet<LineItemTechs>();
            NoteItem = new HashSet<NoteItem>();
            PackageItem = new HashSet<PackageItem>();
            PackageLineSequence = new HashSet<PackageLineSequence>();
            PartFee = new HashSet<PartFee>();
            PartItem = new HashSet<PartItem>();
            RepairArticleLineItem = new HashSet<RepairArticleLineItem>();
            RevisionLineItemSequence = new HashSet<RevisionLineItemSequence>();
            SpecialPackageLineItemSequence = new HashSet<SpecialPackageLineItemSequence>();
            SubletItem = new HashSet<SubletItem>();
        }

        public int LineItemId { get; set; }
        public int? AcctClassId { get; set; }
        public int? CategoryId { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public decimal Sale { get; set; }
        public bool TaxExempt { get; set; }
        public bool NoCommission { get; set; }
        public bool FixedCommission { get; set; }
        public int? OrderRevisionId { get; set; }
        public int? CannedJobId { get; set; }
        public byte[] Timestamp { get; set; }
        public decimal LaborSale { get; set; }
        public decimal PartSale { get; set; }
        public decimal PartOnlySale { get; set; }
        public decimal LaborOnlySale { get; set; }
        public decimal SubletSale { get; set; }
        public decimal PackageSale { get; set; }
        public bool TireFee { get; set; }
        public int? ParentLineItemId { get; set; }
        public int RecordVersion { get; set; }

        public AccountClass AcctClass { get; set; }
        public CannedJob CannedJob { get; set; }
        public Category Category { get; set; }
        public OrderRevision OrderRevision { get; set; }
        public CouponItem CouponItem { get; set; }
        public RepairOrderLineItemSequence RepairOrderLineItemSequence { get; set; }
        public ICollection<CannedJobLineItemSequence> CannedJobLineItemSequence { get; set; }
        public ICollection<LaborItem> LaborItem { get; set; }
        public ICollection<LineItemTaxes> LineItemTaxes { get; set; }
        public ICollection<LineItemTechs> LineItemTechs { get; set; }
        public ICollection<NoteItem> NoteItem { get; set; }
        public ICollection<PackageItem> PackageItem { get; set; }
        public ICollection<PackageLineSequence> PackageLineSequence { get; set; }
        public ICollection<PartFee> PartFee { get; set; }
        public ICollection<PartItem> PartItem { get; set; }
        public ICollection<RepairArticleLineItem> RepairArticleLineItem { get; set; }
        public ICollection<RevisionLineItemSequence> RevisionLineItemSequence { get; set; }
        public ICollection<SpecialPackageLineItemSequence> SpecialPackageLineItemSequence { get; set; }
        public ICollection<SubletItem> SubletItem { get; set; }
    }
}
