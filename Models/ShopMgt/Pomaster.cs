using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Pomaster
    {
        public Pomaster()
        {
            Podetail = new HashSet<Podetail>();
        }

        public int PomasterId { get; set; }
        public int? WriterId { get; set; }
        public int? VendorId { get; set; }
        public DateTime Podate { get; set; }
        public DateTime RequiredDate { get; set; }
        public int PoshipViaId { get; set; }
        public string CommentInternal { get; set; }
        public string CommentReport { get; set; }
        public decimal? TaxTotal { get; set; }
        public decimal? PartsTotal { get; set; }
        public decimal? PartsReceived { get; set; }
        public bool? BackOrder { get; set; }
        public bool IsClosed { get; set; }
        public string Phone { get; set; }
        public string PhoneExt { get; set; }
        public bool? Taxable { get; set; }
        public int PostateId { get; set; }
        public decimal? TaxReceived { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string ConfirmNum { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public PoshipVia PoshipVia { get; set; }
        public Postate Postate { get; set; }
        public Vendor Vendor { get; set; }
        public Employee Writer { get; set; }
        public ICollection<Podetail> Podetail { get; set; }
    }
}
