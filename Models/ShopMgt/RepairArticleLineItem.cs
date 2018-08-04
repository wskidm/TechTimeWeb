using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class RepairArticleLineItem
    {
        public int RepairArticleLineItemId { get; set; }
        public int LineItemId { get; set; }
        public string ArticleId { get; set; }
        public string Module { get; set; }
        public string SubModule { get; set; }
        public string Title { get; set; }
        public string Anchor { get; set; }
        public byte[] Timestamp { get; set; }
        public string Uri { get; set; }
        public int RecordVersion { get; set; }

        public LineItem LineItem { get; set; }
    }
}
