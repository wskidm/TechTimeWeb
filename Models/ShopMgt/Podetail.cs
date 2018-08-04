using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Podetail
    {
        public Podetail()
        {
            PodetailRevision = new HashSet<PodetailRevision>();
        }

        public int PodetailId { get; set; }
        public int PomasterId { get; set; }
        public int? Sequence { get; set; }
        public int? PartId { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityReceived { get; set; }
        public decimal? Cost { get; set; }
        public decimal? CoreCost { get; set; }
        public decimal? QuantityBackOrder { get; set; }
        public decimal? QuantityCancelled { get; set; }
        public bool InventoryPart { get; set; }
        public string Notes { get; set; }
        public decimal? QuantityAvailConf { get; set; }
        public int? MfgId { get; set; }
        public string AltPartNo { get; set; }
        public int? AltMfgId { get; set; }
        public int? RepairOrderId { get; set; }
        public string SaveDescription { get; set; }
        public string WdlineCode { get; set; }
        public string PartType { get; set; }
        public string LocationName { get; set; }
        public decimal? ListPrice { get; set; }
        public byte[] Timestamp { get; set; }
        public string LocationId { get; set; }
        public string Size { get; set; }
        public bool IsTire { get; set; }
        public int RecordVersion { get; set; }

        public PartManufacturer AltMfg { get; set; }
        public PartManufacturer Mfg { get; set; }
        public Part Part { get; set; }
        public Pomaster Pomaster { get; set; }
        public RepairOrder RepairOrder { get; set; }
        public ICollection<PodetailRevision> PodetailRevision { get; set; }
    }
}
