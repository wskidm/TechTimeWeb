using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class AddressType
    {
        public AddressType()
        {
            Addresses = new HashSet<Addresses>();
        }

        public int AddressTypeId { get; set; }
        public string AddressTypeName { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Addresses> Addresses { get; set; }
    }
}
