using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PodetailRevision
    {
        public int OrderRevisionId { get; set; }
        public int PodetailId { get; set; }
        public int RecordVersion { get; set; }

        public OrderRevision OrderRevision { get; set; }
        public Podetail Podetail { get; set; }
    }
}
