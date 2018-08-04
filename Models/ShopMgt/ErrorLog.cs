using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ErrorLog
    {
        public int ErrorLogId { get; set; }
        public int? ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }
    }
}
