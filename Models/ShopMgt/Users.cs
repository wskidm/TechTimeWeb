using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string AccessRights { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }
    }
}
