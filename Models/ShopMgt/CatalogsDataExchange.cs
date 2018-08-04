using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CatalogsDataExchange
    {
        public int ExchangeId { get; set; }
        public string CatalogName { get; set; }
        public int? RepairOrderId { get; set; }
        public int? PurchaseOrderId { get; set; }
        public string VendorInfo { get; set; }
        public string VehicleInfo { get; set; }
        public string DataTransfered { get; set; }
        public string DataReceived { get; set; }
        public DateTime DateRecorded { get; set; }
        public int ActionType { get; set; }
    }
}
