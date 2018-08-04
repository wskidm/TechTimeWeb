using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class EmailTemplate
    {
        public int EmailTemplateId { get; set; }
        public string Type { get; set; }
        public string Template { get; set; }
        public int RecordVersion { get; set; }
    }
}
