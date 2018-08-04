using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class FeeSetting
    {
        public int FeeSettingId { get; set; }
        public string FeeName { get; set; }
        public bool Enabled { get; set; }
        public string Description { get; set; }
        public int? AccountClassId { get; set; }
        public string CalculateMode { get; set; }
        public string CalculateType { get; set; }
        public string TaxableType { get; set; }
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }
        public decimal Value { get; set; }
        public string ApplyRule { get; set; }
        public decimal ApplyRuleValue { get; set; }
        public byte[] RowVersion { get; set; }
        public int RecordVersion { get; set; }

        public AccountClass AccountClass { get; set; }
    }
}
