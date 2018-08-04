using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class TaxCalculationTypes
    {
        public TaxCalculationTypes()
        {
            Tax = new HashSet<Tax>();
        }

        public int CalculationType { get; set; }
        public string Description { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Tax> Tax { get; set; }
    }
}
