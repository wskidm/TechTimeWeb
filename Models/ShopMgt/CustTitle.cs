using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CustTitle
    {
        public CustTitle()
        {
            Customers = new HashSet<Customers>();
        }

        public int TitleId { get; set; }
        public string Title { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Customers> Customers { get; set; }
    }
}
