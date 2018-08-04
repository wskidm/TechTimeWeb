using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Postate
    {
        public Postate()
        {
            Pomaster = new HashSet<Pomaster>();
        }

        public int PostateId { get; set; }
        public string Name { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Pomaster> Pomaster { get; set; }
    }
}
