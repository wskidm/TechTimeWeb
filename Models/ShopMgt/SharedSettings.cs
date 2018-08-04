using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class SharedSettings
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public byte[] Timestamp { get; set; }
        public int SharedSettingsId { get; set; }
        public int RecordVersion { get; set; }
    }
}
