using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            CatalogVehicleAttributes = new HashSet<CatalogVehicleAttributes>();
            CatalogVehicleLink = new HashSet<CatalogVehicleLink>();
            ConnectedVehicleProvider = new HashSet<ConnectedVehicleProvider>();
            OrderRevision = new HashSet<OrderRevision>();
            QuickClose = new HashSet<QuickClose>();
            Recommendations = new HashSet<Recommendations>();
            RepairOrder = new HashSet<RepairOrder>();
            Schedule = new HashSet<Schedule>();
            UserVehicleAttributes = new HashSet<UserVehicleAttributes>();
            VehicleNotes = new HashSet<VehicleNotes>();
            VehicleTaxes = new HashSet<VehicleTaxes>();
        }

        public int VehicleId { get; set; }
        public int? CustId { get; set; }
        public int? Year { get; set; }
        public int? MakeId { get; set; }
        public int? SubModelId { get; set; }
        public int? BodyId { get; set; }
        public int? EngineId { get; set; }
        public int? TransmissionId { get; set; }
        public int? BrakeId { get; set; }
        public int? DriveTypeId { get; set; }
        public int? Gvwid { get; set; }
        public int Odometer1 { get; set; }
        public int Odometer2 { get; set; }
        public float MilesPerDay { get; set; }
        public string Vin { get; set; }
        public string MfgDate { get; set; }
        public DateTime? InspDate { get; set; }
        public DateTime? LastInDate { get; set; }
        public short LastRevision { get; set; }
        public string UnitNo { get; set; }
        public string License { get; set; }
        public string LicenseState { get; set; }
        public int? PartLevel { get; set; }
        public int? LaborLevel { get; set; }
        public bool UseVehicleLevels { get; set; }
        public string VehicleMemo { get; set; }
        public bool VehicleMemoPrintOnOrder { get; set; }
        public bool TaxExempt { get; set; }
        public bool? IncludeInCrmcampaign { get; set; }
        public string Color { get; set; }
        public bool Deleted { get; set; }
        public byte[] Timestamp { get; set; }
        public int VehicleClass { get; set; }
        public string DriverName { get; set; }
        public int? DriverPhoneId { get; set; }
        public decimal EngineHoursIn { get; set; }
        public decimal EngineHoursOut { get; set; }
        public int RecordVersion { get; set; }
        public int? ActiveRecallCount { get; set; }
        public DateTime? ActiveRecallLastChecked { get; set; }

        public BodyStyle Body { get; set; }
        public Brake Brake { get; set; }
        public Customers Cust { get; set; }
        public Drive DriveType { get; set; }
        public PhoneNum DriverPhone { get; set; }
        public Engine Engine { get; set; }
        public Gvw Gvw { get; set; }
        public LaborRateDescription LaborLevelNavigation { get; set; }
        public Make Make { get; set; }
        public PartDiscountDescription PartLevelNavigation { get; set; }
        public SubModel SubModel { get; set; }
        public Transmission Transmission { get; set; }
        public Year YearNavigation { get; set; }
        public ICollection<CatalogVehicleAttributes> CatalogVehicleAttributes { get; set; }
        public ICollection<CatalogVehicleLink> CatalogVehicleLink { get; set; }
        public ICollection<ConnectedVehicleProvider> ConnectedVehicleProvider { get; set; }
        public ICollection<OrderRevision> OrderRevision { get; set; }
        public ICollection<QuickClose> QuickClose { get; set; }
        public ICollection<Recommendations> Recommendations { get; set; }
        public ICollection<RepairOrder> RepairOrder { get; set; }
        public ICollection<Schedule> Schedule { get; set; }
        public ICollection<UserVehicleAttributes> UserVehicleAttributes { get; set; }
        public ICollection<VehicleNotes> VehicleNotes { get; set; }
        public ICollection<VehicleTaxes> VehicleTaxes { get; set; }
    }
}
