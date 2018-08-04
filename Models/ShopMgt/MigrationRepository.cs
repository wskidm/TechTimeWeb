using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class MigrationRepository
    {
        public int DocumentId { get; set; }
        public string DocumentLocalPath { get; set; }
        public long DocumentCrc { get; set; }
        public short? DocumentStatus { get; set; }
        public string DocumentType { get; set; }
        public DateTime LastChangeDate { get; set; }
    }
}
