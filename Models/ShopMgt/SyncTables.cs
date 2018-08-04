using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class SyncTables
    {
        public int TableId { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
    }
}
