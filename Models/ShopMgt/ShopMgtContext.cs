using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TechTime.Models.ShopMgt
{
    public partial class ShopMgtContext : DbContext
    {
        public ShopMgtContext()
        {
        }

        public ShopMgtContext(DbContextOptions<ShopMgtContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AaiaidMapping> AaiaidMapping { get; set; }
        public virtual DbSet<AccountClass> AccountClass { get; set; }
        public virtual DbSet<AcesidMapping> AcesidMapping { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<Alert> Alert { get; set; }
        public virtual DbSet<AlternatePartPrice> AlternatePartPrice { get; set; }
        public virtual DbSet<AttachedPart> AttachedPart { get; set; }
        public virtual DbSet<BodyStyle> BodyStyle { get; set; }
        public virtual DbSet<Brake> Brake { get; set; }
        public virtual DbSet<CannedJob> CannedJob { get; set; }
        public virtual DbSet<CannedJobLineItemSequence> CannedJobLineItemSequence { get; set; }
        public virtual DbSet<CannedJobPartKitSequence> CannedJobPartKitSequence { get; set; }
        public virtual DbSet<CatalogLink> CatalogLink { get; set; }
        public virtual DbSet<CatalogsDataExchange> CatalogsDataExchange { get; set; }
        public virtual DbSet<CatalogVehicleAttributes> CatalogVehicleAttributes { get; set; }
        public virtual DbSet<CatalogVehicleLink> CatalogVehicleLink { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CommissionType> CommissionType { get; set; }
        public virtual DbSet<ConnectedVehicleProvider> ConnectedVehicleProvider { get; set; }
        public virtual DbSet<CouponItem> CouponItem { get; set; }
        public virtual DbSet<CustomerAddresses> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerPhones> CustomerPhones { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<CustomerTaxes> CustomerTaxes { get; set; }
        public virtual DbSet<CustomerYtdadjustment> CustomerYtdadjustment { get; set; }
        public virtual DbSet<CustTitle> CustTitle { get; set; }
        public virtual DbSet<DbVersion> DbVersion { get; set; }
        public virtual DbSet<DecodedVehicleIds> DecodedVehicleIds { get; set; }
        public virtual DbSet<Disclaimer> Disclaimer { get; set; }
        public virtual DbSet<DiscountAmountType> DiscountAmountType { get; set; }
        public virtual DbSet<DiscountCoupon> DiscountCoupon { get; set; }
        public virtual DbSet<Drive> Drive { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplate { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeAddresses> EmployeeAddresses { get; set; }
        public virtual DbSet<EmployeeHours> EmployeeHours { get; set; }
        public virtual DbSet<EmployeePhones> EmployeePhones { get; set; }
        public virtual DbSet<EmployeeType> EmployeeType { get; set; }
        public virtual DbSet<EndOfDayReports> EndOfDayReports { get; set; }
        public virtual DbSet<Engine> Engine { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<Estimate> Estimate { get; set; }
        public virtual DbSet<ExtractionStatus> ExtractionStatus { get; set; }
        public virtual DbSet<FeeSetting> FeeSetting { get; set; }
        public virtual DbSet<FeeTransaction> FeeTransaction { get; set; }
        public virtual DbSet<Followup> Followup { get; set; }
        public virtual DbSet<FollowupType> FollowupType { get; set; }
        public virtual DbSet<Glaccounts> Glaccounts { get; set; }
        public virtual DbSet<GlentryTypes> GlentryTypes { get; set; }
        public virtual DbSet<GroupAssociation> GroupAssociation { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Gvw> Gvw { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryCondition> InventoryCondition { get; set; }
        public virtual DbSet<InventoryTransaction> InventoryTransaction { get; set; }
        public virtual DbSet<InvoiceStatus> InvoiceStatus { get; set; }
        public virtual DbSet<LaborItem> LaborItem { get; set; }
        public virtual DbSet<LaborRateDescription> LaborRateDescription { get; set; }
        public virtual DbSet<LaborRateVersion> LaborRateVersion { get; set; }
        public virtual DbSet<LineItem> LineItem { get; set; }
        public virtual DbSet<LineItemTaxes> LineItemTaxes { get; set; }
        public virtual DbSet<LineItemTechs> LineItemTechs { get; set; }
        public virtual DbSet<Lock> Lock { get; set; }
        public virtual DbSet<Make> Make { get; set; }
        public virtual DbSet<Markup> Markup { get; set; }
        public virtual DbSet<MigrationDocumentStatus> MigrationDocumentStatus { get; set; }
        public virtual DbSet<MigrationRepository> MigrationRepository { get; set; }
        public virtual new DbSet<Model> Model { get; set; }
        public virtual DbSet<NoteItem> NoteItem { get; set; }
        public virtual DbSet<OrderRevision> OrderRevision { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<PackageCommission> PackageCommission { get; set; }
        public virtual DbSet<PackageItem> PackageItem { get; set; }
        public virtual DbSet<PackageLineSequence> PackageLineSequence { get; set; }
        public virtual DbSet<PackageMapping> PackageMapping { get; set; }
        public virtual DbSet<Part> Part { get; set; }
        public virtual DbSet<PartDescription> PartDescription { get; set; }
        public virtual DbSet<PartDiscountDescription> PartDiscountDescription { get; set; }
        public virtual DbSet<PartDiscountVersion> PartDiscountVersion { get; set; }
        public virtual DbSet<PartFee> PartFee { get; set; }
        public virtual DbSet<PartItem> PartItem { get; set; }
        public virtual DbSet<PartKit> PartKit { get; set; }
        public virtual DbSet<PartKitMapping> PartKitMapping { get; set; }
        public virtual DbSet<PartKitParts> PartKitParts { get; set; }
        public virtual DbSet<PartManufacturer> PartManufacturer { get; set; }
        public virtual DbSet<PartNumber> PartNumber { get; set; }
        public virtual DbSet<PartTaxAssociation> PartTaxAssociation { get; set; }
        public virtual DbSet<PartVendor> PartVendor { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentMapping> PaymentMapping { get; set; }
        public virtual DbSet<PaymentTransaction> PaymentTransaction { get; set; }
        public virtual DbSet<PayType> PayType { get; set; }
        public virtual DbSet<PhoneDesc> PhoneDesc { get; set; }
        public virtual DbSet<PhoneNum> PhoneNum { get; set; }
        public virtual DbSet<Podetail> Podetail { get; set; }
        public virtual DbSet<PodetailRevision> PodetailRevision { get; set; }
        public virtual DbSet<Pomaster> Pomaster { get; set; }
        public virtual DbSet<PoshipVia> PoshipVia { get; set; }
        public virtual DbSet<Postate> Postate { get; set; }
        public virtual DbSet<Postcard> Postcard { get; set; }
        public virtual DbSet<QuickClose> QuickClose { get; set; }
        public virtual DbSet<ReasonForVisit> ReasonForVisit { get; set; }
        public virtual DbSet<Recommendations> Recommendations { get; set; }
        public virtual DbSet<RecordNumber> RecordNumber { get; set; }
        public virtual DbSet<ReferralType> ReferralType { get; set; }
        public virtual DbSet<RepairArticleLineItem> RepairArticleLineItem { get; set; }
        public virtual DbSet<RepairOrder> RepairOrder { get; set; }
        public virtual DbSet<RepairOrderLineItemSequence> RepairOrderLineItemSequence { get; set; }
        public virtual DbSet<RepairOrderPhase> RepairOrderPhase { get; set; }
        public virtual DbSet<RepairOrderStatus> RepairOrderStatus { get; set; }
        public virtual DbSet<RepairOrderTaxes> RepairOrderTaxes { get; set; }
        public virtual DbSet<RepairOrderTaxSummary> RepairOrderTaxSummary { get; set; }
        public virtual DbSet<RepairOrderTechRates> RepairOrderTechRates { get; set; }
        public virtual DbSet<RepairOrderTechs> RepairOrderTechs { get; set; }
        public virtual DbSet<ReportClass> ReportClass { get; set; }
        public virtual DbSet<ReportDefinition> ReportDefinition { get; set; }
        public virtual DbSet<ReportParams> ReportParams { get; set; }
        public virtual DbSet<ReportRoprefs> ReportRoprefs { get; set; }
        public virtual DbSet<ReportsUnclassified> ReportsUnclassified { get; set; }
        public virtual DbSet<ReportType> ReportType { get; set; }
        public virtual DbSet<ResumeInfoDetails> ResumeInfoDetails { get; set; }
        public virtual DbSet<RevisionLineItemSequence> RevisionLineItemSequence { get; set; }
        public virtual DbSet<RevisionTaxSummary> RevisionTaxSummary { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<ScheduleCannedJob> ScheduleCannedJob { get; set; }
        public virtual DbSet<ScheduleResource> ScheduleResource { get; set; }
        public virtual DbSet<ScheduleStatus> ScheduleStatus { get; set; }
        public virtual DbSet<SharedSettings> SharedSettings { get; set; }
        public virtual DbSet<ShopMgtVehicleConfig> ShopMgtVehicleConfig { get; set; }
        public virtual DbSet<SpecialPackage> SpecialPackage { get; set; }
        public virtual DbSet<SpecialPackageCategory> SpecialPackageCategory { get; set; }
        public virtual DbSet<SpecialPackageLineItemSequence> SpecialPackageLineItemSequence { get; set; }
        public virtual DbSet<SpecialPackageType> SpecialPackageType { get; set; }
        public virtual DbSet<StandardNotes> StandardNotes { get; set; }
        public virtual DbSet<StandardSymptom> StandardSymptom { get; set; }
        public virtual DbSet<SubletItem> SubletItem { get; set; }
        public virtual DbSet<SubModel> SubModel { get; set; }
        public virtual DbSet<SyncDownQueue> SyncDownQueue { get; set; }
        public virtual DbSet<SyncQueue> SyncQueue { get; set; }
        public virtual DbSet<SyncTables> SyncTables { get; set; }
        public virtual DbSet<SyncUpBatch> SyncUpBatch { get; set; }
        public virtual DbSet<SyncUpBatchStatus> SyncUpBatchStatus { get; set; }
        public virtual DbSet<SyncUpQueue> SyncUpQueue { get; set; }
        public virtual DbSet<Tax> Tax { get; set; }
        public virtual DbSet<TaxCalculationTypes> TaxCalculationTypes { get; set; }
        public virtual DbSet<TaxRates> TaxRates { get; set; }
        public virtual DbSet<TechRole> TechRole { get; set; }
        public virtual DbSet<TireMarkup> TireMarkup { get; set; }
        public virtual DbSet<TransactionType> TransactionType { get; set; }
        public virtual DbSet<Transmission> Transmission { get; set; }
        public virtual DbSet<UpdatesAvailable> UpdatesAvailable { get; set; }
        public virtual DbSet<UpdatesInstallStatus> UpdatesInstallStatus { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserVehicleAttributes> UserVehicleAttributes { get; set; }
        public virtual DbSet<Vdoc> Vdoc { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleConfigurationMapping> VehicleConfigurationMapping { get; set; }
        public virtual DbSet<VehicleLocation> VehicleLocation { get; set; }
        public virtual DbSet<VehicleNotes> VehicleNotes { get; set; }
        public virtual DbSet<VehicleNoteTypes> VehicleNoteTypes { get; set; }
        public virtual DbSet<VehicleTaxes> VehicleTaxes { get; set; }
        public virtual DbSet<VehicleTelemetry> VehicleTelemetry { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorAddresses> VendorAddresses { get; set; }
        public virtual DbSet<VendorLink> VendorLink { get; set; }
        public virtual DbSet<VendorPhones> VendorPhones { get; set; }
        public virtual DbSet<VendorType> VendorType { get; set; }
        public virtual DbSet<Version> Version { get; set; }
        public virtual DbSet<Vinmapping> Vinmapping { get; set; }
        public virtual DbSet<Year> Year { get; set; }
        public virtual DbSet<ZipCode> ZipCode { get; set; }
        public virtual DbSet<ZipCodeAlternate> ZipCodeAlternate { get; set; }

        // Unable to generate entity type for table 'TMP.CommissionLineItems'. Please see the warning messages.
        // Unable to generate entity type for table 'TMP.CommissionLineItemTechs'. Please see the warning messages.
        // Unable to generate entity type for table 'TMP.CommissionRepairOrders'. Please see the warning messages.
        // Unable to generate entity type for table 'TMP.EmployeeLineCommissions'. Please see the warning messages.
        // Unable to generate entity type for table 'TMP.LineItemCosts'. Please see the warning messages.
        // Unable to generate entity type for table 'TMP.LoggedPhoneNumbers'. Please see the warning messages.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AaiaidMapping>(entity =>
            {
                entity.HasKey(e => new { e.Aaiaid, e.VehicleConfigurationId });

                entity.ToTable("AAIAIdMapping", "DMV");

                entity.HasIndex(e => e.VehicleConfigurationId)
                    .HasName("IX_VehicleConfigurationId");

                entity.Property(e => e.Aaiaid).HasColumnName("AAIAId");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.VehicleConfiguration)
                    .WithMany(p => p.AaiaidMapping)
                    .HasForeignKey(d => d.VehicleConfigurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AAIAIdMapping_VehicleConfigurationMapping");
            });

            modelBuilder.Entity<AccountClass>(entity =>
            {
                entity.ToTable("AccountClass", "SM");

                entity.Property(e => e.AccountType).HasMaxLength(10);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<AcesidMapping>(entity =>
            {
                entity.HasKey(e => new { e.AcesId, e.AcesEngineId, e.VehicleConfigurationId });

                entity.ToTable("ACESIdMapping", "DMV");

                entity.HasIndex(e => new { e.AcesId, e.AcesEngineId, e.AcesBaseId, e.AcesEngineConfigId, e.AcesSubModelId, e.VehicleConfigurationId })
                    .HasName("IX_ACESIdMapping_VehicleConfigurationID");

                entity.Property(e => e.AcesId).HasColumnName("AcesID");

                entity.Property(e => e.AcesEngineId).HasColumnName("AcesEngineID");

                entity.Property(e => e.VehicleConfigurationId).HasColumnName("VehicleConfigurationID");

                entity.Property(e => e.AcesBaseId).HasColumnName("AcesBaseID");

                entity.Property(e => e.AcesEngineConfigId).HasColumnName("AcesEngineConfigID");

                entity.Property(e => e.AcesSubModelId).HasColumnName("AcesSubModelID");

                entity.HasOne(d => d.VehicleConfiguration)
                    .WithMany(p => p.AcesidMapping)
                    .HasForeignKey(d => d.VehicleConfigurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACESIdMapping_VehicleConfigurationMapping");
            });

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.ToTable("Addresses", "SM");

                entity.HasIndex(e => e.AddressTypeId);

                entity.HasIndex(e => e.Company)
                    .HasName("IX_AddressesCompany");

                entity.Property(e => e.Address).HasMaxLength(40);

                entity.Property(e => e.City).HasMaxLength(25);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.State).HasMaxLength(20);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.ZipCode).HasMaxLength(10);

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Addresses_AddressType");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.ToTable("AddressType", "SM");

                entity.HasIndex(e => e.AddressTypeName)
                    .HasName("IX_AddressTypeName")
                    .IsUnique();

                entity.Property(e => e.AddressTypeName).HasMaxLength(20);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Alert>(entity =>
            {
                entity.ToTable("Alert", "SM");

                entity.Property(e => e.Dtc)
                    .HasColumnName("DTC")
                    .IsUnicode(false);

                entity.Property(e => e.Latitude).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Resolved).HasColumnType("datetime");

                entity.Property(e => e.Submitted).HasColumnType("datetime");

                entity.HasOne(d => d.ConnectedVehicleProvider)
                    .WithMany(p => p.Alert)
                    .HasForeignKey(d => d.ConnectedVehicleProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert_ConnectedVehicleProvider");

                entity.HasOne(d => d.QuickClose)
                    .WithMany(p => p.Alert)
                    .HasForeignKey(d => d.QuickCloseId)
                    .HasConstraintName("FK_Alert_QuickClose");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.Alert)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_Alert_Schedule");
            });

            modelBuilder.Entity<AlternatePartPrice>(entity =>
            {
                entity.ToTable("AlternatePartPrice", "SM");

                entity.HasIndex(e => new { e.PartId, e.PartDiscountDescriptionId })
                    .HasName("IX_AlternatePartPrice")
                    .IsUnique();

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.PartDiscountDescription)
                    .WithMany(p => p.AlternatePartPrice)
                    .HasForeignKey(d => d.PartDiscountDescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlternatePartPrice_PartDiscountDescription");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.AlternatePartPrice)
                    .HasForeignKey(d => d.PartId)
                    .HasConstraintName("FK_AlternatePartPrice_Part");
            });

            modelBuilder.Entity<AttachedPart>(entity =>
            {
                entity.ToTable("AttachedPart", "SM");

                entity.HasIndex(e => e.PartIdAttached);

                entity.HasIndex(e => new { e.PartId, e.PartIdAttached });

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((1.0))");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.AttachedPartPart)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttachedPart_Part");

                entity.HasOne(d => d.PartIdAttachedNavigation)
                    .WithMany(p => p.AttachedPartPartIdAttachedNavigation)
                    .HasForeignKey(d => d.PartIdAttached)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttachedPart_PartAttached");
            });

            modelBuilder.Entity<BodyStyle>(entity =>
            {
                entity.ToTable("BodyStyle", "DMV");

                entity.Property(e => e.BodyStyleId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Brake>(entity =>
            {
                entity.ToTable("Brake", "DMV");

                entity.Property(e => e.BrakeId).ValueGeneratedNever();

                entity.Property(e => e.BrakeSystemType)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<CannedJob>(entity =>
            {
                entity.ToTable("CannedJob", "SM");

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.MakeId);

                entity.HasIndex(e => e.SubModelId);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Make).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CannedJob)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_CannedJob_Category");

                entity.HasOne(d => d.MakeNavigation)
                    .WithMany(p => p.CannedJob)
                    .HasForeignKey(d => d.MakeId)
                    .HasConstraintName("FK_CannedJob_Make");

                entity.HasOne(d => d.SubModel)
                    .WithMany(p => p.CannedJob)
                    .HasForeignKey(d => d.SubModelId)
                    .HasConstraintName("FK_CannedJob_SubModel");
            });

            modelBuilder.Entity<CannedJobLineItemSequence>(entity =>
            {
                entity.HasKey(e => e.CannedJobLineItemSequenceId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("CannedJobLineItemSequence", "SM");

                entity.HasIndex(e => new { e.CannedJobId, e.LineItem })
                    .HasName("IX_CannedJobLineItemSequence")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CannedJob)
                    .WithMany(p => p.CannedJobLineItemSequence)
                    .HasForeignKey(d => d.CannedJobId)
                    .HasConstraintName("FK_CannedJobLineItemSequence_CannedJob");

                entity.HasOne(d => d.LineItemNavigation)
                    .WithMany(p => p.CannedJobLineItemSequence)
                    .HasForeignKey(d => d.LineItem)
                    .HasConstraintName("FK_CannedJobLineItemSequence_LineItem");
            });

            modelBuilder.Entity<CannedJobPartKitSequence>(entity =>
            {
                entity.HasKey(e => new { e.CannedJobId, e.Sequence });

                entity.ToTable("CannedJobPartKitSequence", "SM");

                entity.HasIndex(e => e.PartKitId);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CannedJob)
                    .WithMany(p => p.CannedJobPartKitSequence)
                    .HasForeignKey(d => d.CannedJobId)
                    .HasConstraintName("FK_CannedJobPartKitSequence_CannedJob");

                entity.HasOne(d => d.PartKit)
                    .WithMany(p => p.CannedJobPartKitSequence)
                    .HasForeignKey(d => d.PartKitId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CannedJobPartKitSequence_PartKit");
            });

            modelBuilder.Entity<CatalogLink>(entity =>
            {
                entity.ToTable("CatalogLink", "SM");

                entity.Property(e => e.CatalogLinkId).ValueGeneratedNever();

                entity.Property(e => e.AuthCode).HasMaxLength(13);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Undefined Vendor')");

                entity.Property(e => e.InterfaceVersion).HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<CatalogsDataExchange>(entity =>
            {
                entity.HasKey(e => e.ExchangeId);

                entity.ToTable("CatalogsDataExchange", "DPR");

                entity.Property(e => e.CatalogName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateRecorded).HasColumnType("datetime");

                entity.Property(e => e.VehicleInfo).IsRequired();

                entity.Property(e => e.VendorInfo)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<CatalogVehicleAttributes>(entity =>
            {
                entity.HasKey(e => new { e.VehicleId, e.CatKey });

                entity.ToTable("CatalogVehicleAttributes", "SM");

                entity.Property(e => e.CatKey).HasMaxLength(30);

                entity.Property(e => e.CatValue)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.CatalogVehicleAttributes)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatalogVehicleAttributes_Vehicle");
            });

            modelBuilder.Entity<CatalogVehicleLink>(entity =>
            {
                entity.HasKey(e => new { e.CatalogLinkId, e.VehicleId });

                entity.ToTable("CatalogVehicleLink", "SM");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CatalogLink)
                    .WithMany(p => p.CatalogVehicleLink)
                    .HasForeignKey(d => d.CatalogLinkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatalogVehicleLink_CatalogLink");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.CatalogVehicleLink)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatalogVehicleLink_Vehicle");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category", "SM");

                entity.HasIndex(e => e.Description)
                    .HasName("IX_Category")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<CommissionType>(entity =>
            {
                entity.ToTable("CommissionType", "SM");

                entity.Property(e => e.CommissionTypeId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ConnectedVehicleProvider>(entity =>
            {
                entity.ToTable("ConnectedVehicleProvider", "SM");

                entity.Property(e => e.Received).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusChanged).HasColumnType("datetime");

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasMaxLength(17);

                entity.Property(e => e.XmlData).HasColumnType("xml");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.ConnectedVehicleProvider)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK_ConnectedVehicleProvider_Customers");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.ConnectedVehicleProvider)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_ConnectedVehicleProvider_Vehicle");
            });

            modelBuilder.Entity<CouponItem>(entity =>
            {
                entity.HasKey(e => e.LineItemId);

                entity.ToTable("CouponItem", "SM");

                entity.HasIndex(e => e.CouponId);

                entity.HasIndex(e => e.LaborAccountClassId);

                entity.HasIndex(e => e.LineItemId);

                entity.HasIndex(e => e.PartsAccountClassId);

                entity.Property(e => e.LineItemId).ValueGeneratedNever();

                entity.Property(e => e.ActualLaborDiscount).HasColumnType("money");

                entity.Property(e => e.ActualPartsDiscount).HasColumnType("money");

                entity.Property(e => e.LaborDiscountAmount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PartDiscountAmount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponItem)
                    .HasForeignKey(d => d.CouponId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_CouponItem_DiscountCoupon");

                entity.HasOne(d => d.LaborAccountClass)
                    .WithMany(p => p.CouponItemLaborAccountClass)
                    .HasForeignKey(d => d.LaborAccountClassId)
                    .HasConstraintName("FK_CouponItem_LaborAccountClass");

                entity.HasOne(d => d.LineItem)
                    .WithOne(p => p.CouponItem)
                    .HasForeignKey<CouponItem>(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CouponItem_LineItem");

                entity.HasOne(d => d.PartsAccountClass)
                    .WithMany(p => p.CouponItemPartsAccountClass)
                    .HasForeignKey(d => d.PartsAccountClassId)
                    .HasConstraintName("FK_CouponItem_PartsAccountClass");
            });

            modelBuilder.Entity<CustomerAddresses>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.ToTable("CustomerAddresses", "SM");

                entity.HasIndex(e => e.CustId)
                    .HasName("IX_CustomerAddresses_CustId");

                entity.Property(e => e.AddressId).ValueGeneratedNever();

                entity.Property(e => e.CustId).HasColumnName("CustID");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Address)
                    .WithOne(p => p.CustomerAddresses)
                    .HasForeignKey<CustomerAddresses>(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerAddresses_Addresses");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerAddresses_Customers");
            });

            modelBuilder.Entity<CustomerPhones>(entity =>
            {
                entity.HasKey(e => e.PhoneId);

                entity.ToTable("CustomerPhones", "SM");

                entity.HasIndex(e => e.CustId);

                entity.Property(e => e.PhoneId).ValueGeneratedNever();

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.CustomerPhones)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_CustomerPhones");

                entity.HasOne(d => d.Phone)
                    .WithOne(p => p.CustomerPhones)
                    .HasForeignKey<CustomerPhones>(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerPhones_PhoneNum");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.ToTable("Customers", "SM");

                entity.HasIndex(e => e.MembershipNo);

                entity.HasIndex(e => e.RefById);

                entity.HasIndex(e => e.RefTypeId);

                entity.HasIndex(e => e.TitleId);

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.CustId })
                    .HasName("IX_Customers_Names");

                entity.Property(e => e.CustId).HasDefaultValueSql("(NEXT VALUE FOR [SM].[CustomersSequence])");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.ChargeOk)
                    .IsRequired()
                    .HasColumnName("ChargeOK")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreditAmt)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.CurrentFeeAmount).HasColumnType("money");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailReminder)
                    .IsRequired()
                    .HasColumnName("EMailReminder")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FeeAssessmentDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirstVisited).HasColumnType("datetime");

                entity.Property(e => e.IncludeInCrmcampaign)
                    .IsRequired()
                    .HasColumnName("IncludeInCRMCampaign")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastVisited).HasColumnType("datetime");

                entity.Property(e => e.MembershipNo)
                    .IsRequired()
                    .HasMaxLength(22)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewCustFollowUpDate).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Remarks).HasDefaultValueSql("('')");

                entity.Property(e => e.RepairOrderAdjustment).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ResaleNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SpouseName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LaborLevelNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.LaborLevel)
                    .HasConstraintName("FK_Customers_LaborRateDescription");

                entity.HasOne(d => d.PartLevelNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.PartLevel)
                    .HasConstraintName("FK_Customers_PartDiscountDescription");

                entity.HasOne(d => d.RefType)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.RefTypeId)
                    .HasConstraintName("FK_Customers_ReferralType");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.TitleId)
                    .HasConstraintName("FK_Customers_CustTitle");
            });

            modelBuilder.Entity<CustomerTaxes>(entity =>
            {
                entity.HasKey(e => new { e.CustId, e.TaxId });

                entity.ToTable("CustomerTaxes", "SM");

                entity.HasIndex(e => e.CustId);

                entity.HasIndex(e => e.TaxId);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.CustomerTaxes)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerTaxes_Customers");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.CustomerTaxes)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerTaxes_Tax");
            });

            modelBuilder.Entity<CustomerYtdadjustment>(entity =>
            {
                entity.ToTable("CustomerYTDAdjustment", "SM");

                entity.HasIndex(e => e.CustId);

                entity.Property(e => e.CustomerYtdadjustmentId).HasColumnName("CustomerYTDAdjustmentId");

                entity.Property(e => e.DateAdjusted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.Ytdadjustment)
                    .HasColumnName("YTDAdjustment")
                    .HasColumnType("money");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.CustomerYtdadjustment)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK_Customers_CustomerYTDAdjustment");
            });

            modelBuilder.Entity<CustTitle>(entity =>
            {
                entity.HasKey(e => e.TitleId);

                entity.ToTable("CustTitle", "SM");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.Title).HasMaxLength(20);
            });

            modelBuilder.Entity<DbVersion>(entity =>
            {
                entity.ToTable("DbVersion", "SM");

                entity.HasIndex(e => e.DbVersionId);

                entity.Property(e => e.DbVersionNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.UpgradeDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DecodedVehicleIds>(entity =>
            {
                entity.ToTable("DecodedVehicleIds", "SM");

                entity.HasIndex(e => e.VehicleId);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<Disclaimer>(entity =>
            {
                entity.HasKey(e => e.RoPhase);

                entity.ToTable("Disclaimer", "SM");

                entity.Property(e => e.RoPhase)
                    .HasColumnName("RO_Phase")
                    .ValueGeneratedNever();

                entity.Property(e => e.Disclaimer1)
                    .IsRequired()
                    .HasColumnName("Disclaimer")
                    .HasMaxLength(2000);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.RoPhaseNavigation)
                    .WithOne(p => p.Disclaimer)
                    .HasForeignKey<Disclaimer>(d => d.RoPhase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Disclaimer_RepairOrderPhase");
            });

            modelBuilder.Entity<DiscountAmountType>(entity =>
            {
                entity.HasKey(e => e.AmountTypeId);

                entity.ToTable("DiscountAmountType", "SM");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<DiscountCoupon>(entity =>
            {
                entity.HasKey(e => e.CouponId);

                entity.ToTable("DiscountCoupon", "SM");

                entity.HasIndex(e => e.AmountTypeId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(N'Discount Coupon')");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LaborOff)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PartsOff)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AmountType)
                    .WithMany(p => p.DiscountCoupon)
                    .HasForeignKey(d => d.AmountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountCoupon_DiscountAmountType");
            });

            modelBuilder.Entity<Drive>(entity =>
            {
                entity.ToTable("Drive", "DMV");

                entity.Property(e => e.DriveId).ValueGeneratedNever();

                entity.Property(e => e.DriveType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.ToTable("EmailTemplate", "SM");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Template).IsRequired();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee", "SM");

                entity.HasIndex(e => e.AccountingId);

                entity.HasIndex(e => e.EmployeeTypeId);

                entity.HasIndex(e => e.PayTypeId);

                entity.Property(e => e.AccountingId).HasMaxLength(21);

                entity.Property(e => e.CommLabor).HasColumnType("decimal(6, 3)");

                entity.Property(e => e.CommParts).HasColumnType("decimal(6, 3)");

                entity.Property(e => e.CommSublet).HasColumnType("decimal(6, 3)");

                entity.Property(e => e.DischargedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).HasMaxLength(512);

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.HiredDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastPayRaiseDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(1024);

                entity.Property(e => e.PayPeriodHours).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.WageAmount).HasColumnType("money");

                entity.HasOne(d => d.CommTypeLaborNavigation)
                    .WithMany(p => p.EmployeeCommTypeLaborNavigation)
                    .HasForeignKey(d => d.CommTypeLabor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_CommissionType1");

                entity.HasOne(d => d.CommTypePartsNavigation)
                    .WithMany(p => p.EmployeeCommTypePartsNavigation)
                    .HasForeignKey(d => d.CommTypeParts)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_CommissionType");

                entity.HasOne(d => d.CommTypeSubletNavigation)
                    .WithMany(p => p.EmployeeCommTypeSubletNavigation)
                    .HasForeignKey(d => d.CommTypeSublet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_CommissionType2");

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_EmployeeType");

                entity.HasOne(d => d.PayType)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.PayTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_PayType");
            });

            modelBuilder.Entity<EmployeeAddresses>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.ToTable("EmployeeAddresses", "SM");

                entity.HasIndex(e => e.EmployeeId);

                entity.Property(e => e.AddressId).ValueGeneratedNever();

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Address)
                    .WithOne(p => p.EmployeeAddresses)
                    .HasForeignKey<EmployeeAddresses>(d => d.AddressId)
                    .HasConstraintName("FK_EmployeeAddresses_Addresses");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeAddresses)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeeAddresses_Employee");
            });

            modelBuilder.Entity<EmployeeHours>(entity =>
            {
                entity.ToTable("EmployeeHours", "SM");

                entity.HasIndex(e => new { e.EmployeeId, e.DayOfWeek })
                    .HasName("IX_EmployeeHours_EmployeeId_EmployeeHoursId")
                    .IsUnique();

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeHours)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeHours_EmployeeId");
            });

            modelBuilder.Entity<EmployeePhones>(entity =>
            {
                entity.HasKey(e => e.PhoneId);

                entity.ToTable("EmployeePhones", "SM");

                entity.HasIndex(e => e.EmployeeId);

                entity.Property(e => e.PhoneId).ValueGeneratedNever();

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeePhones)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeePhones_Employee");

                entity.HasOne(d => d.Phone)
                    .WithOne(p => p.EmployeePhones)
                    .HasForeignKey<EmployeePhones>(d => d.PhoneId)
                    .HasConstraintName("FK_EmployeePhones_PhoneNum");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("EmployeeType", "SM");

                entity.Property(e => e.EmployeeTypeId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<EndOfDayReports>(entity =>
            {
                entity.ToTable("EndOfDayReports", "SM");

                entity.HasIndex(e => e.ReportId);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.EndOfDayReports)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("FK_ReportDefinition_EndOfDayReports");
            });

            modelBuilder.Entity<Engine>(entity =>
            {
                entity.ToTable("Engine", "DMV");

                entity.HasIndex(e => e.DisplacementCid);

                entity.Property(e => e.EngineId).ValueGeneratedNever();

                entity.Property(e => e.BlockConfiguration).HasMaxLength(30);

                entity.Property(e => e.BoostType).HasMaxLength(50);

                entity.Property(e => e.DisplacementCid).HasColumnName("DisplacementCID");

                entity.Property(e => e.FuelControlType).HasMaxLength(50);

                entity.Property(e => e.FuelDeliveryMethodType).HasMaxLength(50);

                entity.Property(e => e.FuelSystem).HasMaxLength(30);

                entity.Property(e => e.FuelSystemConfiguration).HasMaxLength(30);

                entity.Property(e => e.FuelType).HasMaxLength(50);

                entity.Property(e => e.HeadConfigurationType).HasMaxLength(50);

                entity.Property(e => e.IgnitionSystem).HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.VinCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("ErrorLog", "SM");

                entity.HasIndex(e => e.ErrorLogId);

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Estimate>(entity =>
            {
                entity.ToTable("Estimate", "SM");

                entity.HasIndex(e => e.RepairOrderId)
                    .HasName("IX_Estimate")
                    .IsUnique();

                entity.Property(e => e.EstShopSuppliesCost).HasColumnType("money");

                entity.Property(e => e.EstimatedDiscount).HasColumnType("money");

                entity.Property(e => e.EstimatedHazMatCost).HasColumnType("money");

                entity.Property(e => e.EstimatedHours).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.EstimatedLaborCost).HasColumnType("money");

                entity.Property(e => e.EstimatedPartsCost).HasColumnType("money");

                entity.Property(e => e.EstimatedTaxAmount).HasColumnType("money");

                entity.Property(e => e.EstimatedTireFeeCost).HasColumnType("money");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.RepairOrder)
                    .WithOne(p => p.Estimate)
                    .HasForeignKey<Estimate>(d => d.RepairOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Estimate_RepairOrder");
            });

            modelBuilder.Entity<ExtractionStatus>(entity =>
            {
                entity.ToTable("ExtractionStatus", "SM");

                entity.Property(e => e.InitialExtractDone).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastExtractionStamp)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TempExtractionStamp).HasMaxLength(8);
            });

            modelBuilder.Entity<FeeSetting>(entity =>
            {
                entity.ToTable("FeeSetting", "SM");

                entity.HasIndex(e => e.FeeName)
                    .HasName("IX_FeeSetting_UniqueName")
                    .IsUnique();

                entity.Property(e => e.ApplyRule)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CalculateMode)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CalculateType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FeeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.TaxableType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.HasOne(d => d.AccountClass)
                    .WithMany(p => p.FeeSetting)
                    .HasForeignKey(d => d.AccountClassId)
                    .HasConstraintName("FK_FeeSetting_AccountClass");
            });

            modelBuilder.Entity<FeeTransaction>(entity =>
            {
                entity.ToTable("FeeTransaction", "SM");

                entity.HasIndex(e => e.AccountClassId);

                entity.HasIndex(e => e.CustomerId);

                entity.Property(e => e.Amount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.FeeBalance).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.HasOne(d => d.AccountClass)
                    .WithMany(p => p.FeeTransaction)
                    .HasForeignKey(d => d.AccountClassId)
                    .HasConstraintName("FK_FeeTransaction_AccountClass");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.FeeTransaction)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeTransaction_Customers");
            });

            modelBuilder.Entity<Followup>(entity =>
            {
                entity.ToTable("Followup", "SM");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.FollowupTypeNavigation)
                    .WithMany(p => p.Followup)
                    .HasForeignKey(d => d.FollowupType)
                    .HasConstraintName("FK_Followups_FollowupType");
            });

            modelBuilder.Entity<FollowupType>(entity =>
            {
                entity.ToTable("FollowupType", "SM");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Glaccounts>(entity =>
            {
                entity.HasKey(e => e.GlaccountId);

                entity.ToTable("GLAccounts", "SM");

                entity.HasIndex(e => e.AccountClassId);

                entity.HasIndex(e => e.EntryTypeId);

                entity.Property(e => e.GlaccountId).HasColumnName("GLAccountId");

                entity.Property(e => e.Description).HasMaxLength(25);

                entity.Property(e => e.Glcode)
                    .IsRequired()
                    .HasColumnName("GLCode")
                    .HasMaxLength(12);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AccountClass)
                    .WithMany(p => p.Glaccounts)
                    .HasForeignKey(d => d.AccountClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountClass");

                entity.HasOne(d => d.EntryType)
                    .WithMany(p => p.Glaccounts)
                    .HasForeignKey(d => d.EntryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GLEntryType");
            });

            modelBuilder.Entity<GlentryTypes>(entity =>
            {
                entity.HasKey(e => e.EntryTypeId);

                entity.ToTable("GLEntryTypes", "SM");

                entity.Property(e => e.EntryTypeDescription).HasMaxLength(25);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<GroupAssociation>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.CustId });

                entity.ToTable("GroupAssociation", "SM");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.GroupAssociation)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupAssociation_Customers");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupAssociation)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupAssociation_Groups");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("Groups", "SM");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Groups")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Gvw>(entity =>
            {
                entity.ToTable("GVW", "DMV");

                entity.Property(e => e.Gvwid)
                    .HasColumnName("GVWId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Gvwtext)
                    .IsRequired()
                    .HasColumnName("GVWText")
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("Inventory", "SM");

                entity.HasIndex(e => e.ConditionId);

                entity.HasIndex(e => e.PartId);

                entity.Property(e => e.AvailableQty)
                    .HasColumnType("decimal(12, 2)")
                    .HasComputedColumnSql("(isnull(([OnHand]+[OnOrder])-[SM].[fnCommittedPartCount]([PartId]),(0)))");

                entity.Property(e => e.CommittedQty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LastSold).HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OnHand).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OnOrder).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OrderPoint).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PayCommission)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.RestockQty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Condition)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.ConditionId)
                    .HasConstraintName("FK_Inventory_InventoryCondition");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.InventoryPart)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventory_Part");

                entity.HasOne(d => d.SupercededByNavigation)
                    .WithMany(p => p.InventorySupercededByNavigation)
                    .HasForeignKey(d => d.SupercededBy)
                    .HasConstraintName("FK_Inventory_Part_Supercede");
            });

            modelBuilder.Entity<InventoryCondition>(entity =>
            {
                entity.HasKey(e => e.ConditionId);

                entity.ToTable("InventoryCondition", "SM");

                entity.Property(e => e.ConditionId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<InventoryTransaction>(entity =>
            {
                entity.ToTable("InventoryTransaction", "SM");

                entity.HasIndex(e => e.PartId)
                    .HasName("IX_InventoryTransaction_Part");

                entity.HasIndex(e => e.PurchaseOrderId);

                entity.HasIndex(e => e.TransactionDate);

                entity.HasIndex(e => e.TransactionTypeId);

                entity.HasIndex(e => e.VendorId)
                    .HasName("IX_InventoryTransaction_Vendor");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.InventoryTransaction)
                    .HasForeignKey(d => d.PartId)
                    .HasConstraintName("FK_InventoryTransaction_Part");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.InventoryTransaction)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryTransaction_TransactionType");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.InventoryTransaction)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_InventoryTransaction_Vendor");
            });

            modelBuilder.Entity<InvoiceStatus>(entity =>
            {
                entity.ToTable("InvoiceStatus", "SM");

                entity.HasIndex(e => e.Description);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<LaborItem>(entity =>
            {
                entity.HasKey(e => e.LaborItemId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LaborItem", "SM");

                entity.HasIndex(e => e.LaborRateDescriptionId);

                entity.HasIndex(e => e.LineItemId);

                entity.Property(e => e.HoursCharged).HasColumnType("decimal(18, 12)");

                entity.Property(e => e.IsChangedMplgItem).HasColumnName("IsChangedMPlgItem");

                entity.Property(e => e.IsMplgItem).HasColumnName("IsMPlgItem");

                entity.Property(e => e.PartsEstimate)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Symptom).HasMaxLength(255);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LaborRateDescription)
                    .WithMany(p => p.LaborItem)
                    .HasForeignKey(d => d.LaborRateDescriptionId)
                    .HasConstraintName("FK_LaborItem_LaborRateDescription");

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.LaborItem)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LaborItem_LineItem");
            });

            modelBuilder.Entity<LaborRateDescription>(entity =>
            {
                entity.ToTable("LaborRateDescription", "SM");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(21);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<LaborRateVersion>(entity =>
            {
                entity.ToTable("LaborRateVersion", "SM");

                entity.HasIndex(e => e.LaborRateDescriptionId);

                entity.Property(e => e.LaborRate).HasColumnType("money");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.VersionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.LaborRateDescription)
                    .WithMany(p => p.LaborRateVersion)
                    .HasForeignKey(d => d.LaborRateDescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LaborRateVersion_LaborRateDescription");
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.ToTable("LineItem", "SM");

                entity.HasIndex(e => e.AcctClassId);

                entity.HasIndex(e => e.CannedJobId);

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.Description);

                entity.HasIndex(e => e.OrderRevisionId);

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LaborOnlySale).HasColumnType("money");

                entity.Property(e => e.LaborSale).HasColumnType("money");

                entity.Property(e => e.PackageSale).HasColumnType("money");

                entity.Property(e => e.PartOnlySale).HasColumnType("money");

                entity.Property(e => e.PartSale).HasColumnType("money");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Sale).HasColumnType("money");

                entity.Property(e => e.SubletSale).HasColumnType("money");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AcctClass)
                    .WithMany(p => p.LineItem)
                    .HasForeignKey(d => d.AcctClassId)
                    .HasConstraintName("FK_LineItem_AccountClass");

                entity.HasOne(d => d.CannedJob)
                    .WithMany(p => p.LineItem)
                    .HasForeignKey(d => d.CannedJobId)
                    .HasConstraintName("FK_LineItem_CannedJob");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.LineItem)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_LineItem_Category");

                entity.HasOne(d => d.OrderRevision)
                    .WithMany(p => p.LineItem)
                    .HasForeignKey(d => d.OrderRevisionId)
                    .HasConstraintName("FK_LineItem_OrderRevision");
            });

            modelBuilder.Entity<LineItemTaxes>(entity =>
            {
                entity.HasKey(e => new { e.LineItemId, e.TaxId });

                entity.ToTable("LineItemTaxes", "SM");

                entity.HasIndex(e => e.LineItemId);

                entity.HasIndex(e => e.TaxId);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.TaxCharged).HasColumnType("money");

                entity.Property(e => e.TaxRate).HasColumnType("money");

                entity.Property(e => e.TaxedTaxes).HasColumnType("money");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.LineItemTaxes)
                    .HasForeignKey(d => d.LineItemId)
                    .HasConstraintName("FK_LineItemTaxes_LineItem");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.LineItemTaxes)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LineItemTaxes_Tax");
            });

            modelBuilder.Entity<LineItemTechs>(entity =>
            {
                entity.ToTable("LineItemTechs", "SM");

                entity.HasIndex(e => e.EmployeeId);

                entity.HasIndex(e => e.LineItemId);

                entity.Property(e => e.LineItemTechsId).HasColumnName("LineItemTechsID");

                entity.Property(e => e.Commission).HasColumnType("money");

                entity.Property(e => e.HoursActual).HasColumnType("decimal(18, 12)");

                entity.Property(e => e.HoursPay).HasColumnType("decimal(18, 12)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LineItemTechs)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_LineItemTechs_Employee");

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.LineItemTechs)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LineItemTechs_LineItem");
            });

            modelBuilder.Entity<Lock>(entity =>
            {
                entity.ToTable("Lock", "SM");

                entity.HasIndex(e => new { e.RepairOrderId, e.OrderRevisionId })
                    .HasName("IX_Lock")
                    .IsUnique();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Make>(entity =>
            {
                entity.ToTable("Make", "DMV");

                entity.HasIndex(e => e.Name);

                entity.Property(e => e.MakeId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Markup>(entity =>
            {
                entity.ToTable("Markup", "SM");

                entity.HasIndex(e => e.MaxRange);

                entity.Property(e => e.Percentage).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<MigrationDocumentStatus>(entity =>
            {
                entity.HasKey(e => e.DocumentStatusId);

                entity.ToTable("MigrationDocumentStatus", "Sync");

                entity.Property(e => e.DocumentStatusId).ValueGeneratedNever();

                entity.Property(e => e.DocumentStatusDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigrationRepository>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.ToTable("MigrationRepository", "Sync");

                entity.HasIndex(e => e.DocumentLocalPath)
                    .HasName("ucDocumentLocalPath")
                    .IsUnique();

                entity.Property(e => e.DocumentId).ValueGeneratedNever();

                entity.Property(e => e.DocumentCrc).HasColumnName("DocumentCRC");

                entity.Property(e => e.DocumentLocalPath)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.ToTable("Model", "DMV");

                entity.HasIndex(e => e.MakeId);

                entity.HasIndex(e => e.Name);

                entity.Property(e => e.ModelId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Make)
                    .WithMany(p => p.Model)
                    .HasForeignKey(d => d.MakeId)
                    .HasConstraintName("FK_Model_Make");
            });

            modelBuilder.Entity<NoteItem>(entity =>
            {
                entity.ToTable("NoteItem", "SM");

                entity.HasIndex(e => e.LineItemId);

                entity.Property(e => e.NoteText).HasDefaultValueSql("('')");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.NoteItem)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NoteItem_LineItem");
            });

            modelBuilder.Entity<OrderRevision>(entity =>
            {
                entity.ToTable("OrderRevision", "SM");

                entity.HasIndex(e => e.RepairOrderId);

                entity.HasIndex(e => e.VehicleId);

                entity.HasIndex(e => e.WriterId);

                entity.Property(e => e.AuthorizedBy).HasMaxLength(30);

                entity.Property(e => e.CurrentEstimate).HasColumnType("money");

                entity.Property(e => e.DiscountAmt).HasColumnType("money");

                entity.Property(e => e.HazWasteAmt).HasColumnType("money");

                entity.Property(e => e.InitiatedBy).HasMaxLength(10);

                entity.Property(e => e.LaborAmount).HasColumnType("money");

                entity.Property(e => e.NumberCalled).HasMaxLength(50);

                entity.Property(e => e.PartsAmount).HasColumnType("money");

                entity.Property(e => e.Reason).HasMaxLength(40);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.RevisionAmount).HasColumnType("money");

                entity.Property(e => e.RevisionDate).HasColumnType("datetime");

                entity.Property(e => e.ShopSuppliesAmt).HasColumnType("money");

                entity.Property(e => e.SubletAmount).HasColumnType("money");

                entity.Property(e => e.TaxAmtHazMat).HasColumnType("money");

                entity.Property(e => e.TaxAmtShopSupplies).HasColumnType("money");

                entity.Property(e => e.TaxCharged).HasColumnType("money");

                entity.Property(e => e.TimeOfCall).HasColumnType("datetime");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TireFeeAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.RepairOrder)
                    .WithMany(p => p.OrderRevision)
                    .HasForeignKey(d => d.RepairOrderId)
                    .HasConstraintName("FK_OrderRevision_RepairOrder");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.OrderRevision)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_OrderRevision_Vehicle");

                entity.HasOne(d => d.Writer)
                    .WithMany(p => p.OrderRevision)
                    .HasForeignKey(d => d.WriterId)
                    .HasConstraintName("FK_OrderRevision_Employee");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.ToTable("Package", "SM");

                entity.HasIndex(e => e.AcctClassId);

                entity.HasIndex(e => e.CategoryId);

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.AcctClassId).HasColumnName("AcctClassID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Sale).HasColumnType("money");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Package_Category");
            });

            modelBuilder.Entity<PackageCommission>(entity =>
            {
                entity.ToTable("PackageCommission", "SM");

                entity.HasIndex(e => e.PackageId);

                entity.Property(e => e.PackageCommissionId).HasColumnName("PackageCommissionID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.PayHours).HasColumnType("decimal(18, 12)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.PackageCommission)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageCommission_Package");
            });

            modelBuilder.Entity<PackageItem>(entity =>
            {
                entity.ToTable("PackageItem", "SM");

                entity.HasIndex(e => e.LineItemId);

                entity.HasIndex(e => e.PackageId);

                entity.Property(e => e.PackageCode).HasMaxLength(32);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.PackageItem)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageItem_LineItem");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.PackageItem)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_PackageItem_Package");
            });

            modelBuilder.Entity<PackageLineSequence>(entity =>
            {
                entity.HasKey(e => new { e.PackageItemId, e.LineItemId });

                entity.ToTable("PackageLineSequence", "SM");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.PackageLineSequence)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageLineSequence_LineItem");

                entity.HasOne(d => d.PackageItem)
                    .WithMany(p => p.PackageLineSequence)
                    .HasForeignKey(d => d.PackageItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PackageLineSequence_PackageItem");
            });

            modelBuilder.Entity<PackageMapping>(entity =>
            {
                entity.ToTable("PackageMapping", "QBI");

                entity.HasIndex(e => e.OriginalId);

                entity.HasIndex(e => e.PackageId);

                entity.Property(e => e.OriginatingTableName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PackageId).HasColumnName("PackageID");
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.ToTable("Part", "SM");

                entity.HasIndex(e => e.AccountClassId);

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.KitId);

                entity.HasIndex(e => e.ManufacturerId);

                entity.HasIndex(e => e.PartFeeId);

                entity.HasIndex(e => new { e.Description, e.ManufacturerId });

                entity.Property(e => e.CoreCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CoreListPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsChangedMplgitem).HasColumnName("IsChangedMPLGItem");

                entity.Property(e => e.IsMplgitem).HasColumnName("IsMPLGItem");

                entity.Property(e => e.ListPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AccountClass)
                    .WithMany(p => p.Part)
                    .HasForeignKey(d => d.AccountClassId)
                    .HasConstraintName("FK_Part_AccountClass");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Part)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Part_Category");

                entity.HasOne(d => d.Kit)
                    .WithMany(p => p.Part)
                    .HasForeignKey(d => d.KitId)
                    .HasConstraintName("FK_Part_PartKit");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Part)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_Part_PartManufacturer");

                entity.HasOne(d => d.PartFee)
                    .WithMany(p => p.Part)
                    .HasForeignKey(d => d.PartFeeId)
                    .HasConstraintName("FK_Part_PartFee");
            });

            modelBuilder.Entity<PartDescription>(entity =>
            {
                entity.ToTable("PartDescription", "SM");

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.Code)
                    .HasName("IX_PartCode")
                    .IsUnique();

                entity.HasIndex(e => e.VendorId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PartDescription)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_PartDescription_Category");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.PartDescription)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_PartDescription_Vendor");
            });

            modelBuilder.Entity<PartDiscountDescription>(entity =>
            {
                entity.ToTable("PartDiscountDescription", "SM");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(21);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<PartDiscountVersion>(entity =>
            {
                entity.ToTable("PartDiscountVersion", "SM");

                entity.HasIndex(e => e.PartDiscountDescriptionId);

                entity.Property(e => e.PartDiscount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.VersionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.PartDiscountDescription)
                    .WithMany(p => p.PartDiscountVersion)
                    .HasForeignKey(d => d.PartDiscountDescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartDiscountVersion_PartDiscountDescription");
            });

            modelBuilder.Entity<PartFee>(entity =>
            {
                entity.ToTable("PartFee", "SM");

                entity.HasIndex(e => e.LineItemId);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.PartFee)
                    .HasForeignKey(d => d.LineItemId)
                    .HasConstraintName("FK_PartFee_LineItem");
            });

            modelBuilder.Entity<PartItem>(entity =>
            {
                entity.HasKey(e => e.PartItemId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("PartItem", "SM");

                entity.HasIndex(e => e.LineItemId);

                entity.HasIndex(e => e.PartDiscountDescriptionId);

                entity.HasIndex(e => e.PartId);

                entity.HasIndex(e => e.VendorId);

                entity.HasIndex(e => new { e.PartNo, e.ManufacturerId });

                entity.Property(e => e.CommissionAmount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ConfirmedQuantity).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.IsChangedMplgItem).HasColumnName("IsChangedMPlgItem");

                entity.Property(e => e.IsMplgItem).HasColumnName("IsMPlgItem");

                entity.Property(e => e.PartNo).HasMaxLength(50);

                entity.Property(e => e.PartType).HasMaxLength(6);

                entity.Property(e => e.Quantity).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.UnitCost).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.UnitList).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.UnitSale).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.VendorCode).HasMaxLength(8);

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.PartItem)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartItem_LineItem");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.PartItem)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_PartItem_PartManufacturer");

                entity.HasOne(d => d.PartDiscountDescription)
                    .WithMany(p => p.PartItem)
                    .HasForeignKey(d => d.PartDiscountDescriptionId)
                    .HasConstraintName("FK_PartItem_PartDiscountDescription");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.PartItem)
                    .HasForeignKey(d => d.PartId)
                    .HasConstraintName("FK_PartItem_Part");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.PartItem)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_PartItem_Vendor");
            });

            modelBuilder.Entity<PartKit>(entity =>
            {
                entity.ToTable("PartKit", "SM");

                entity.HasIndex(e => e.AccountClassId);

                entity.HasIndex(e => e.CategoryId);

                entity.Property(e => e.PartKitId).HasColumnName("PartKitID");

                entity.Property(e => e.AccountClassId).HasColumnName("AccountClassID");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ListPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AccountClass)
                    .WithMany(p => p.PartKit)
                    .HasForeignKey(d => d.AccountClassId)
                    .HasConstraintName("FK_PartKit_AccountClass");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PartKit)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_PartKit_Category");
            });

            modelBuilder.Entity<PartKitMapping>(entity =>
            {
                entity.ToTable("PartKitMapping", "QBI");

                entity.HasIndex(e => e.OriginalId);

                entity.HasIndex(e => e.PartKitId);

                entity.Property(e => e.OriginatingTableName)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<PartKitParts>(entity =>
            {
                entity.ToTable("PartKitParts", "SM");

                entity.HasIndex(e => e.PartId);

                entity.HasIndex(e => e.PartKitId);

                entity.Property(e => e.PartKitPartsId).HasColumnName("PartKitPartsID");

                entity.Property(e => e.PartId).HasColumnName("PartID");

                entity.Property(e => e.PartKitId).HasColumnName("PartKitID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("TIMESTAMP")
                    .IsRowVersion();

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.PartKitParts)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartKitParts_Part");

                entity.HasOne(d => d.PartKit)
                    .WithMany(p => p.PartKitParts)
                    .HasForeignKey(d => d.PartKitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartKitParts_PartKit");
            });

            modelBuilder.Entity<PartManufacturer>(entity =>
            {
                entity.HasKey(e => e.ManufacturerId);

                entity.ToTable("PartManufacturer", "SM");

                entity.HasIndex(e => e.Code)
                    .HasName("IX_PartManufacturer_Code")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<PartNumber>(entity =>
            {
                entity.ToTable("PartNumber", "SM");

                entity.HasIndex(e => e.PartId);

                entity.HasIndex(e => e.PartNumber1);

                entity.Property(e => e.IsBasePart)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PartNumber1)
                    .IsRequired()
                    .HasColumnName("PartNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.PartNumber)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartNumber_Part");
            });

            modelBuilder.Entity<PartTaxAssociation>(entity =>
            {
                entity.HasKey(e => new { e.PartId, e.TaxId });

                entity.ToTable("PartTaxAssociation", "SM");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.PartTaxAssociation)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartTaxAssociation_Part");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.PartTaxAssociation)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartTaxAssociation_Tax");
            });

            modelBuilder.Entity<PartVendor>(entity =>
            {
                entity.HasKey(e => e.PartVendorId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("PartVendor", "SM");

                entity.HasIndex(e => e.VendorId);

                entity.HasIndex(e => new { e.PartId, e.Priority })
                    .HasName("IX_PartVendor")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.PartVendor)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartVendor_Part");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.PartVendor)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartVendor_Vendor");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment", "SM");

                entity.HasIndex(e => e.AccountClassId);

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_Payment_Customer");

                entity.HasIndex(e => e.InvoiceStatusId);

                entity.HasIndex(e => e.PaymentTransactionId);

                entity.HasIndex(e => e.RepairOrderId)
                    .HasName("IX_Payment_RepairOrder");

                entity.Property(e => e.Amount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AuthData)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckData)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletionDate).HasColumnType("datetime");

                entity.Property(e => e.IsNsf).HasColumnName("IsNSF");

                entity.Property(e => e.IsNsfreversal).HasColumnName("IsNSFReversal");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TotalPayment).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.AccountClass)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.AccountClassId)
                    .HasConstraintName("FK_Payment_AccountClass");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Payment_Customers");

                entity.HasOne(d => d.InvoiceStatus)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.InvoiceStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_InvoiceStatus");

                entity.HasOne(d => d.PaymentTransaction)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.PaymentTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_PaymentTransaction");

                entity.HasOne(d => d.RepairOrder)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.RepairOrderId)
                    .HasConstraintName("FK_Payment_RepairOrder");
            });

            modelBuilder.Entity<PaymentMapping>(entity =>
            {
                entity.ToTable("PaymentMapping", "QBI");

                entity.HasIndex(e => e.OriginalId);

                entity.HasIndex(e => e.PaymentId);

                entity.Property(e => e.OriginatingTableName)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<PaymentTransaction>(entity =>
            {
                entity.ToTable("PaymentTransaction", "SM");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<PayType>(entity =>
            {
                entity.ToTable("PayType", "SM");

                entity.Property(e => e.PayTypeId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<PhoneDesc>(entity =>
            {
                entity.ToTable("PhoneDesc", "SM");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<PhoneNum>(entity =>
            {
                entity.HasKey(e => e.PhoneId);

                entity.ToTable("PhoneNum", "SM");

                entity.HasIndex(e => e.PhoneDescId);

                entity.HasIndex(e => new { e.PhoneNum1, e.Ext })
                    .HasName("IX_PhoneNum_PhoneNumExt");

                entity.Property(e => e.Ext).HasMaxLength(5);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.PhoneNum1)
                    .HasColumnName("PhoneNum")
                    .HasMaxLength(15);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.PhoneDesc)
                    .WithMany(p => p.PhoneNum)
                    .HasForeignKey(d => d.PhoneDescId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhoneNum_PhoneDesc");
            });

            modelBuilder.Entity<Podetail>(entity =>
            {
                entity.ToTable("PODetail", "SM");

                entity.HasIndex(e => e.PartId);

                entity.HasIndex(e => e.PomasterId);

                entity.HasIndex(e => new { e.PartNumber, e.Description, e.MfgId })
                    .HasName("IX_PODetail_PartNumber_Desc_MfgId");

                entity.HasIndex(e => new { e.RepairOrderId, e.AltPartNo, e.AltMfgId });

                entity.HasIndex(e => new { e.RepairOrderId, e.AltPartNo, e.SaveDescription })
                    .HasName("IX_PODetail_RepairOrderId_AltPartNo_SaveDesc");

                entity.Property(e => e.PodetailId).HasColumnName("PODetailId");

                entity.Property(e => e.AltPartNo).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.LocationId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationName).HasMaxLength(21);

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.PartNumber).HasMaxLength(20);

                entity.Property(e => e.PartType).HasMaxLength(6);

                entity.Property(e => e.PomasterId).HasColumnName("POMasterId");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.SaveDescription).HasMaxLength(50);

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.WdlineCode)
                    .HasColumnName("WDLineCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.AltMfg)
                    .WithMany(p => p.PodetailAltMfg)
                    .HasForeignKey(d => d.AltMfgId)
                    .HasConstraintName("FK_PODetail_MfgId2");

                entity.HasOne(d => d.Mfg)
                    .WithMany(p => p.PodetailMfg)
                    .HasForeignKey(d => d.MfgId)
                    .HasConstraintName("FK_PODetail_MfgId1");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.Podetail)
                    .HasForeignKey(d => d.PartId)
                    .HasConstraintName("FK_PODetail_Part");

                entity.HasOne(d => d.Pomaster)
                    .WithMany(p => p.Podetail)
                    .HasForeignKey(d => d.PomasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PODetail_POMaster");

                entity.HasOne(d => d.RepairOrder)
                    .WithMany(p => p.Podetail)
                    .HasForeignKey(d => d.RepairOrderId)
                    .HasConstraintName("FK_PODetail_RepairOrder");
            });

            modelBuilder.Entity<PodetailRevision>(entity =>
            {
                entity.HasKey(e => new { e.OrderRevisionId, e.PodetailId });

                entity.ToTable("PODetailRevision", "SM");

                entity.Property(e => e.PodetailId).HasColumnName("PODetailId");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.OrderRevision)
                    .WithMany(p => p.PodetailRevision)
                    .HasForeignKey(d => d.OrderRevisionId)
                    .HasConstraintName("FK_PORevision_OrderRevision");

                entity.HasOne(d => d.Podetail)
                    .WithMany(p => p.PodetailRevision)
                    .HasForeignKey(d => d.PodetailId)
                    .HasConstraintName("FK_PORevision_POMaster");
            });

            modelBuilder.Entity<Pomaster>(entity =>
            {
                entity.ToTable("POMaster", "SM");

                entity.HasIndex(e => e.PoshipViaId);

                entity.HasIndex(e => e.PostateId);

                entity.HasIndex(e => e.VendorId);

                entity.HasIndex(e => e.WriterId);

                entity.Property(e => e.PomasterId)
                    .HasColumnName("POMasterId")
                    .HasDefaultValueSql("(NEXT VALUE FOR [SM].[POMasterSequence])");

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.ConfirmNum).HasMaxLength(32);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.PhoneExt).HasMaxLength(5);

                entity.Property(e => e.Podate)
                    .HasColumnName("PODate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PoshipViaId).HasColumnName("POShipViaId");

                entity.Property(e => e.PostateId).HasColumnName("POStateId");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.RequiredDate).HasColumnType("date");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.PoshipVia)
                    .WithMany(p => p.Pomaster)
                    .HasForeignKey(d => d.PoshipViaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POMaster_POShipVia");

                entity.HasOne(d => d.Postate)
                    .WithMany(p => p.Pomaster)
                    .HasForeignKey(d => d.PostateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POMaster_POState");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Pomaster)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_POMaster_Vendor");

                entity.HasOne(d => d.Writer)
                    .WithMany(p => p.Pomaster)
                    .HasForeignKey(d => d.WriterId)
                    .HasConstraintName("FK_POMaster_Employee");
            });

            modelBuilder.Entity<PoshipVia>(entity =>
            {
                entity.ToTable("POShipVia", "SM");

                entity.Property(e => e.PoshipViaId)
                    .HasColumnName("POShipViaId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Postate>(entity =>
            {
                entity.ToTable("POState", "SM");

                entity.Property(e => e.PostateId)
                    .HasColumnName("POStateId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Postcard>(entity =>
            {
                entity.ToTable("Postcard", "SM");

                entity.HasIndex(e => e.ReportId);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReportId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<QuickClose>(entity =>
            {
                entity.ToTable("QuickClose", "SM");

                entity.Property(e => e.Closed).HasColumnType("datetime");

                entity.Property(e => e.CustomerComments).HasMaxLength(1000);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShopComments).HasMaxLength(1000);

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.QuickClose)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK_QuickClose_Customer");

                entity.HasOne(d => d.ServiceWriter)
                    .WithMany(p => p.QuickClose)
                    .HasForeignKey(d => d.ServiceWriterId)
                    .HasConstraintName("FK_QuickClose_ServiceWriter");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.QuickClose)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_QuickClose_Vehicle");
            });

            modelBuilder.Entity<ReasonForVisit>(entity =>
            {
                entity.ToTable("ReasonForVisit", "SM");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Recommendations>(entity =>
            {
                entity.HasKey(e => e.RecommendationId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Recommendations", "SM");

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.VehicleId)
                    .ForSqlServerIsClustered();

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

                entity.Property(e => e.RecommendDate).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Recommendations)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Recommendations_Category");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Recommendations)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_Recommendations_Vehicle");
            });

            modelBuilder.Entity<RecordNumber>(entity =>
            {
                entity.ToTable("RecordNumber", "SM");

                entity.HasIndex(e => e.RepairOrderId)
                    .HasName("RepairOrderId_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.RecordNumberId).HasDefaultValueSql("(NEXT VALUE FOR [SM].[RecordNumberSequence])");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.RepairOrder)
                    .WithOne(p => p.RecordNumber)
                    .HasForeignKey<RecordNumber>(d => d.RepairOrderId)
                    .HasConstraintName("FK_RecordNumber_RepairOrder");
            });

            modelBuilder.Entity<ReferralType>(entity =>
            {
                entity.HasKey(e => e.RefTypeId);

                entity.ToTable("ReferralType", "SM");

                entity.HasIndex(e => e.HasCustId);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TypeName).HasMaxLength(30);
            });

            modelBuilder.Entity<RepairArticleLineItem>(entity =>
            {
                entity.ToTable("RepairArticleLineItem", "SM");

                entity.HasIndex(e => e.ArticleId);

                entity.HasIndex(e => e.LineItemId);

                entity.Property(e => e.Anchor)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ArticleId)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.SubModule)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.RepairArticleLineItem)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairArticleLineItem_LineItem");
            });

            modelBuilder.Entity<RepairOrder>(entity =>
            {
                entity.ToTable("RepairOrder", "SM");

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.DatePosted);

                entity.HasIndex(e => e.LaborRateDescriptionId);

                entity.HasIndex(e => e.PartDiscountDescriptionId);

                entity.HasIndex(e => e.RateVersionDate)
                    .HasName("RepairOrder_Rate_Index");

                entity.HasIndex(e => e.ReasonForVisitId);

                entity.HasIndex(e => e.RepairOrderPhaseId)
                    .HasName("IX_RepairOrder_PhaseId");

                entity.HasIndex(e => e.VehicleId);

                entity.HasIndex(e => new { e.CustId, e.VehicleId });

                entity.HasIndex(e => new { e.RepairOrderPhaseId, e.DatePosted })
                    .HasName("RepairOrder_Phase_Index");

                entity.Property(e => e.RepairOrderId).HasDefaultValueSql("(NEXT VALUE FOR [SM].[RepairOrderSequence])");

                entity.Property(e => e.BalanceDueAdjustment).HasColumnType("money");

                entity.Property(e => e.DatePosted).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmt)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EngineHoursIn).HasColumnType("decimal(7, 1)");

                entity.Property(e => e.EngineHoursOut).HasColumnType("decimal(7, 1)");

                entity.Property(e => e.Hat).HasMaxLength(8);

                entity.Property(e => e.HazWasteAmt)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LaborSale)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Location).HasMaxLength(30);

                entity.Property(e => e.MarginPct).HasColumnType("money");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observations)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderTotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PartsSale)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintedDate).HasColumnType("datetime");

                entity.Property(e => e.PromiseDate).HasColumnType("datetime");

                entity.Property(e => e.RateVersionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReferenceNumber).HasMaxLength(12);

                entity.Property(e => e.ScheduleDate).HasColumnType("datetime");

                entity.Property(e => e.ScheduledHours).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ShopSuppliesAmt)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusDescription).HasMaxLength(21);

                entity.Property(e => e.TaxAmtHazMat)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxAmtShopSupplies)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TireFeeSale)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalTaxAmt)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.RepairOrder)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_RepairOrder_Category");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.RepairOrder)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK_RepairOrder_Customer");

                entity.HasOne(d => d.LaborRateDescription)
                    .WithMany(p => p.RepairOrder)
                    .HasForeignKey(d => d.LaborRateDescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairOrder_LaborRateDescription");

                entity.HasOne(d => d.PartDiscountDescription)
                    .WithMany(p => p.RepairOrder)
                    .HasForeignKey(d => d.PartDiscountDescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairOrder_PartDiscountDescription");

                entity.HasOne(d => d.ReasonForVisit)
                    .WithMany(p => p.RepairOrder)
                    .HasForeignKey(d => d.ReasonForVisitId)
                    .HasConstraintName("FK_RepairOrder_ReasonForVisit");

                entity.HasOne(d => d.RepairOrderPhase)
                    .WithMany(p => p.RepairOrder)
                    .HasForeignKey(d => d.RepairOrderPhaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairOrder_RepairOrderPhase");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.RepairOrder)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_RepairOrder_VehicleId");
            });

            modelBuilder.Entity<RepairOrderLineItemSequence>(entity =>
            {
                entity.HasKey(e => e.RepairOrderLineItemSequenceId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("RepairOrderLineItemSequence", "SM");

                entity.HasIndex(e => e.LineItemId)
                    .HasName("IX_RepairOrderLineItemSequenceLineId")
                    .IsUnique();

                entity.HasIndex(e => new { e.RepairOrderId, e.LineItemId })
                    .HasName("IX_RepairOrderLineItemSequence")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LineItem)
                    .WithOne(p => p.RepairOrderLineItemSequence)
                    .HasForeignKey<RepairOrderLineItemSequence>(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LineItem_LineItemSeq");

                entity.HasOne(d => d.RepairOrder)
                    .WithMany(p => p.RepairOrderLineItemSequence)
                    .HasForeignKey(d => d.RepairOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairOrderLineItemSequence");
            });

            modelBuilder.Entity<RepairOrderPhase>(entity =>
            {
                entity.ToTable("RepairOrderPhase", "SM");

                entity.Property(e => e.RepairOrderPhaseId).ValueGeneratedNever();

                entity.Property(e => e.Phase)
                    .IsRequired()
                    .HasMaxLength(21);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RepairOrderStatus>(entity =>
            {
                entity.ToTable("RepairOrderStatus", "SM");

                entity.HasIndex(e => e.StatusDescription)
                    .HasName("RepairOrderStatus_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusDescription)
                    .IsRequired()
                    .HasMaxLength(21);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RepairOrderTaxes>(entity =>
            {
                entity.HasKey(e => new { e.RepairOrderId, e.TaxId });

                entity.ToTable("RepairOrderTaxes", "SM");

                entity.HasIndex(e => e.RepairOrderId)
                    .HasName("IX_RepairOrderTaxes_TaxId");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.RepairOrder)
                    .WithMany(p => p.RepairOrderTaxes)
                    .HasForeignKey(d => d.RepairOrderId)
                    .HasConstraintName("FK_RepairOrderTaxes_RepairOrder");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.RepairOrderTaxes)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairOrderTaxes_Tax");
            });

            modelBuilder.Entity<RepairOrderTaxSummary>(entity =>
            {
                entity.HasKey(e => new { e.RepairOrderId, e.TaxId, e.TaxRateId });

                entity.ToTable("RepairOrderTaxSummary", "SM");

                entity.Property(e => e.LaborTaxCharged).HasColumnType("money");

                entity.Property(e => e.MatlTaxCharged).HasColumnType("money");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TotalTaxCharged).HasColumnType("money");

                entity.HasOne(d => d.RepairOrder)
                    .WithMany(p => p.RepairOrderTaxSummary)
                    .HasForeignKey(d => d.RepairOrderId)
                    .HasConstraintName("FK_RepairOrderTaxSummary_RepairOrder");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.RepairOrderTaxSummary)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairOrderTaxSummary_Tax");

                entity.HasOne(d => d.TaxRate)
                    .WithMany(p => p.RepairOrderTaxSummary)
                    .HasPrincipalKey(p => p.TaxRateId)
                    .HasForeignKey(d => d.TaxRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairOrderTaxSummary_TaxRates");
            });

            modelBuilder.Entity<RepairOrderTechRates>(entity =>
            {
                entity.HasKey(e => new { e.RepairOrderId, e.EmployeeId, e.EmployeeType });

                entity.ToTable("RepairOrderTechRates", "SM");

                entity.HasIndex(e => e.PayTypeId);

                entity.Property(e => e.CommLabor).HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CommParts).HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CommSublet).HasColumnType("decimal(19, 3)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CommTypeLaborNavigation)
                    .WithMany(p => p.RepairOrderTechRatesCommTypeLaborNavigation)
                    .HasForeignKey(d => d.CommTypeLabor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairOrderTechRates_CommissionType");

                entity.HasOne(d => d.CommTypePartsNavigation)
                    .WithMany(p => p.RepairOrderTechRatesCommTypePartsNavigation)
                    .HasForeignKey(d => d.CommTypeParts)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairOrderTechRates_CommissionType1");

                entity.HasOne(d => d.CommTypeSubletNavigation)
                    .WithMany(p => p.RepairOrderTechRatesCommTypeSubletNavigation)
                    .HasForeignKey(d => d.CommTypeSublet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairOrderTechRates_CommissionType2");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.RepairOrderTechRates)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairOrderTechRates_Employee");

                entity.HasOne(d => d.EmployeeTypeNavigation)
                    .WithMany(p => p.RepairOrderTechRates)
                    .HasForeignKey(d => d.EmployeeType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairOrderTechRates_EmployeeType");

                entity.HasOne(d => d.PayType)
                    .WithMany(p => p.RepairOrderTechRates)
                    .HasForeignKey(d => d.PayTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RepairOrderTechRates_PayType");

                entity.HasOne(d => d.RepairOrder)
                    .WithMany(p => p.RepairOrderTechRates)
                    .HasForeignKey(d => d.RepairOrderId)
                    .HasConstraintName("FK_RepairOrderTechRates_RepairOrder");
            });

            modelBuilder.Entity<RepairOrderTechs>(entity =>
            {
                entity.ToTable("RepairOrderTechs", "SM");

                entity.HasIndex(e => e.TechnicianId);

                entity.HasIndex(e => new { e.RepairOrderId, e.TechRoleId })
                    .HasName("IX_RepairOrderTechs_RepairOrderid_TechRoleId");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.RepairOrder)
                    .WithMany(p => p.RepairOrderTechs)
                    .HasForeignKey(d => d.RepairOrderId)
                    .HasConstraintName("FK_RepairOrderTechs_RepairOrder");

                entity.HasOne(d => d.TechRole)
                    .WithMany(p => p.RepairOrderTechs)
                    .HasForeignKey(d => d.TechRoleId)
                    .HasConstraintName("FK_RepairOrderTechs_TechRole");

                entity.HasOne(d => d.Technician)
                    .WithMany(p => p.RepairOrderTechs)
                    .HasForeignKey(d => d.TechnicianId)
                    .HasConstraintName("FK_Employee_RepairOrderTechs");
            });

            modelBuilder.Entity<ReportClass>(entity =>
            {
                entity.ToTable("ReportClass", "SM");

                entity.Property(e => e.ReportClassId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ReportDefinition>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("ReportDefinition", "SM");

                entity.HasIndex(e => e.ReportClassId);

                entity.HasIndex(e => e.ReportTypeId);

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.ReportClass)
                    .WithMany(p => p.ReportDefinition)
                    .HasForeignKey(d => d.ReportClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportClass_ReportDefinition");

                entity.HasOne(d => d.ReportType)
                    .WithMany(p => p.ReportDefinition)
                    .HasForeignKey(d => d.ReportTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportType_ReportDefinition");
            });

            modelBuilder.Entity<ReportParams>(entity =>
            {
                entity.ToTable("ReportParams", "SM");

                entity.HasIndex(e => e.ReportId);

                entity.Property(e => e.ParamName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ParamVal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportParams)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDefinition_ReportParams");
            });

            modelBuilder.Entity<ReportRoprefs>(entity =>
            {
                entity.ToTable("ReportROPrefs", "SM");

                entity.HasIndex(e => e.ReportId);

                entity.HasIndex(e => e.ReportRoprefsId);

                entity.Property(e => e.ReportRoprefsId).HasColumnName("ReportROPrefsId");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.RoreportType).HasColumnName("ROReportType");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ReportsUnclassified>(entity =>
            {
                entity.ToTable("ReportsUnclassified", "SM");

                entity.HasIndex(e => e.ReportId);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportsUnclassified)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportsUnclassified_ReportDefinition");
            });

            modelBuilder.Entity<ReportType>(entity =>
            {
                entity.ToTable("ReportType", "SM");

                entity.Property(e => e.ReportTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ResumeInfoDetails>(entity =>
            {
                entity.HasKey(e => new { e.UpdatesAvailableId, e.ComponentId });

                entity.ToTable("ResumeInfoDetails", "Sync");

                entity.HasOne(d => d.UpdatesAvailable)
                    .WithMany(p => p.ResumeInfoDetails)
                    .HasForeignKey(d => d.UpdatesAvailableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResumeInfoDetails_UpdatesAvailable");
            });

            modelBuilder.Entity<RevisionLineItemSequence>(entity =>
            {
                entity.HasKey(e => e.RevisionLineItemSequenceId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("RevisionLineItemSequence", "SM");

                entity.HasIndex(e => new { e.OrderRevisionId, e.LineItemId })
                    .HasName("IX_RevisionLineItemSequence")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.RevisionLineItemSequence)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LineItem_RevisionLineItemSequence");

                entity.HasOne(d => d.OrderRevision)
                    .WithMany(p => p.RevisionLineItemSequence)
                    .HasForeignKey(d => d.OrderRevisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderRevision_RevisionLineItemSequence");
            });

            modelBuilder.Entity<RevisionTaxSummary>(entity =>
            {
                entity.HasKey(e => e.RevisionTaxSummaryId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("RevisionTaxSummary", "SM");

                entity.HasIndex(e => new { e.OrderRevisionId, e.TaxId, e.TaxRateId })
                    .HasName("IX_RevisionTaxSummary")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.HazMatLineItemType).HasDefaultValueSql("((1))");

                entity.Property(e => e.HazMatTaxCharged).HasColumnType("money");

                entity.Property(e => e.LaborTaxCharged).HasColumnType("money");

                entity.Property(e => e.MatlTaxCharged).HasColumnType("money");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShopSuppliesTaxCharged).HasColumnType("money");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TotalTaxCharged).HasColumnType("money");

                entity.HasOne(d => d.OrderRevision)
                    .WithMany(p => p.RevisionTaxSummary)
                    .HasForeignKey(d => d.OrderRevisionId)
                    .HasConstraintName("FK_RevisionTaxSummary_OrderRevision");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.RevisionTaxSummary)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RevisionTaxSummary_Tax");

                entity.HasOne(d => d.TaxRate)
                    .WithMany(p => p.RevisionTaxSummary)
                    .HasPrincipalKey(p => p.TaxRateId)
                    .HasForeignKey(d => d.TaxRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RevisionTaxSummary_TaxRates");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule", "SM");

                entity.Property(e => e.AutoAdjust)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CustomerNotes).HasMaxLength(1000);

                entity.Property(e => e.DropOffDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.PromisedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Schedule_Category");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK_Schedule_Customers");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ScheduleEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Schedule_Employee");

                entity.HasOne(d => d.PrimaryCustomerPhone)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.PrimaryCustomerPhoneId)
                    .HasConstraintName("FK_Schedule_SchedulePrimaryCustomerPhone");

                entity.HasOne(d => d.ReasonForVisit)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.ReasonForVisitId)
                    .HasConstraintName("FK_Schedule_ReasonForVisit");

                entity.HasOne(d => d.RepairOrder)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.RepairOrderId)
                    .HasConstraintName("FK_Schedule_RepairOrder");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_Schedule_ScheduleResource");

                entity.HasOne(d => d.ServiceWriter)
                    .WithMany(p => p.ScheduleServiceWriter)
                    .HasForeignKey(d => d.ServiceWriterId)
                    .HasConstraintName("FK_Schedule_ServiceWriter_Employee");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_ScheduleStatus");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_Schedule_Vehicle");
            });

            modelBuilder.Entity<ScheduleCannedJob>(entity =>
            {
                entity.ToTable("ScheduleCannedJob", "SM");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.CannedJob)
                    .WithMany(p => p.ScheduleCannedJob)
                    .HasForeignKey(d => d.CannedJobId)
                    .HasConstraintName("FK_ScheduleCannedJob_CannedJob");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ScheduleCannedJob)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_ScheduleCannedJob_Category");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.ScheduleCannedJob)
                    .HasForeignKey(d => d.ScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleCannedJob_Schedule");
            });

            modelBuilder.Entity<ScheduleResource>(entity =>
            {
                entity.HasKey(e => e.ResourceId);

                entity.ToTable("ScheduleResource", "SM");

                entity.Property(e => e.BrandName).HasMaxLength(120);

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Location).HasMaxLength(120);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.NickName).HasMaxLength(25);

                entity.Property(e => e.Notes).HasMaxLength(2048);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.SerialNumber).HasMaxLength(120);

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.WarrantyInformation).HasMaxLength(1024);
            });

            modelBuilder.Entity<ScheduleStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("ScheduleStatus", "SM");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(48);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion();
            });

            modelBuilder.Entity<SharedSettings>(entity =>
            {
                entity.ToTable("SharedSettings", "SM");

                entity.HasIndex(e => e.Key)
                    .HasName("UX_SharedSettings_KeyUnique")
                    .IsUnique();

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ShopMgtVehicleConfig>(entity =>
            {
                entity.ToTable("ShopMgtVehicleConfig", "DMV");

                entity.HasIndex(e => e.BodyStyleId);

                entity.HasIndex(e => e.BrakeId);

                entity.HasIndex(e => e.DriveId)
                    .HasName("IX_ShopMgtVehicleConfig_Driveid");

                entity.HasIndex(e => e.EngineId);

                entity.HasIndex(e => e.Gvwid);

                entity.HasIndex(e => e.MakeId);

                entity.HasIndex(e => e.ModelId);

                entity.HasIndex(e => e.SubModelId);

                entity.HasIndex(e => e.TransmissionId);

                entity.HasIndex(e => e.Year);

                entity.HasIndex(e => new { e.ShopMgtVehicleConfigId, e.MakeId, e.SubModelId, e.BodyStyleId, e.EngineId, e.BrakeId, e.TransmissionId, e.Gvwid, e.DriveId, e.Year })
                    .HasName("IX_ShopMgtVehicleConfig_Year2");

                entity.Property(e => e.Gvwid).HasColumnName("GVWId");

                entity.HasOne(d => d.BodyStyle)
                    .WithMany(p => p.ShopMgtVehicleConfig)
                    .HasForeignKey(d => d.BodyStyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopMgtVehicleConfig_BodyStyle");

                entity.HasOne(d => d.Brake)
                    .WithMany(p => p.ShopMgtVehicleConfig)
                    .HasForeignKey(d => d.BrakeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopMgtVehicleConfig_Brake");

                entity.HasOne(d => d.Drive)
                    .WithMany(p => p.ShopMgtVehicleConfig)
                    .HasForeignKey(d => d.DriveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopMgtVehicleConfig_Drive");

                entity.HasOne(d => d.Engine)
                    .WithMany(p => p.ShopMgtVehicleConfig)
                    .HasForeignKey(d => d.EngineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopMgtVehicleConfig_Engine");

                entity.HasOne(d => d.Gvw)
                    .WithMany(p => p.ShopMgtVehicleConfig)
                    .HasForeignKey(d => d.Gvwid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopMgtVehicleConfig_GVW");

                entity.HasOne(d => d.Make)
                    .WithMany(p => p.ShopMgtVehicleConfig)
                    .HasForeignKey(d => d.MakeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopMgtVehicleConfig_Make");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.ShopMgtVehicleConfig)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopMgtVehicleConfig_Model");

                entity.HasOne(d => d.SubModel)
                    .WithMany(p => p.ShopMgtVehicleConfig)
                    .HasForeignKey(d => d.SubModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopMgtVehicleConfig_SubModel");

                entity.HasOne(d => d.Transmission)
                    .WithMany(p => p.ShopMgtVehicleConfig)
                    .HasForeignKey(d => d.TransmissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopMgtVehicleConfig_Transmission");

                entity.HasOne(d => d.YearNavigation)
                    .WithMany(p => p.ShopMgtVehicleConfig)
                    .HasForeignKey(d => d.Year)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopMgtVehicleConfig_Year");
            });

            modelBuilder.Entity<SpecialPackage>(entity =>
            {
                entity.ToTable("SpecialPackage", "SM");

                entity.HasIndex(e => e.SpecialPackageCategoryId);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.SpecialPackageCategory)
                    .WithMany(p => p.SpecialPackage)
                    .HasForeignKey(d => d.SpecialPackageCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpecialPackage_SpecialPackageLevel");
            });

            modelBuilder.Entity<SpecialPackageCategory>(entity =>
            {
                entity.ToTable("SpecialPackageCategory", "SM");

                entity.HasIndex(e => e.SpecialPackageTypeId);

                entity.Property(e => e.CategoryDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.SpecialPackageType)
                    .WithMany(p => p.SpecialPackageCategory)
                    .HasForeignKey(d => d.SpecialPackageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpecialPackageCategory_SpecialPackageType");
            });

            modelBuilder.Entity<SpecialPackageLineItemSequence>(entity =>
            {
                entity.HasKey(e => e.SpecialPackageLineItemSequenceId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SpecialPackageLineItemSequence", "SM");

                entity.HasIndex(e => e.LineItemId);

                entity.HasIndex(e => e.SpecialPackageId);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.SpecialPackageLineItemSequence)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpecialPackageLineItemSequence_LineItem");

                entity.HasOne(d => d.SpecialPackage)
                    .WithMany(p => p.SpecialPackageLineItemSequence)
                    .HasForeignKey(d => d.SpecialPackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpecialPackageLineItemSequence_SpecialPackage");
            });

            modelBuilder.Entity<SpecialPackageType>(entity =>
            {
                entity.ToTable("SpecialPackageType", "SM");

                entity.Property(e => e.SpecialPackageTypeId).ValueGeneratedNever();

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.SpecialPackageType1)
                    .IsRequired()
                    .HasColumnName("SpecialPackageType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StandardNotes>(entity =>
            {
                entity.ToTable("StandardNotes", "SM");

                entity.Property(e => e.Description).HasMaxLength(30);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<StandardSymptom>(entity =>
            {
                entity.ToTable("StandardSymptom", "SM");

                entity.HasIndex(e => e.CategoryId);

                entity.Property(e => e.EstimatedLaborCost).HasColumnType("money");

                entity.Property(e => e.EstimatedLaborHours).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EstimatedPartsCost).HasColumnType("money");

                entity.Property(e => e.LongDescription).HasMaxLength(255);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShortDescription).HasMaxLength(25);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.WorkRequested).HasMaxLength(255);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.StandardSymptom)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_StandardSymptom_Category");
            });

            modelBuilder.Entity<SubletItem>(entity =>
            {
                entity.ToTable("SubletItem", "SM");

                entity.HasIndex(e => e.LineItemId);

                entity.HasIndex(e => e.VendorId);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.SubletItem)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubletItem_LineItem");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.SubletItem)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_SubletItem_Vendor");
            });

            modelBuilder.Entity<SubModel>(entity =>
            {
                entity.ToTable("SubModel", "DMV");

                entity.HasIndex(e => e.Dmvid);

                entity.HasIndex(e => e.ModelId);

                entity.HasIndex(e => e.Name);

                entity.Property(e => e.SubModelId).ValueGeneratedNever();

                entity.Property(e => e.Dmvid).HasColumnName("DMVId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.SubModel)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK_SubModel_Model");
            });

            modelBuilder.Entity<SyncDownQueue>(entity =>
            {
                entity.ToTable("SyncDownQueue", "Sync");

                entity.Property(e => e.DataXml).HasColumnName("DataXML");

                entity.Property(e => e.RecordTs).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SyncQueue>(entity =>
            {
                entity.ToTable("SyncQueue", "Sync");

                entity.HasIndex(e => e.BatchId)
                    .HasName("ixSyncQueue_BatchId");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.SyncQueue)
                    .HasForeignKey(d => d.BatchId)
                    .HasConstraintName("FK_SyncQueue_SyncUpBatch");

                entity.HasOne(d => d.SyncDownQueue)
                    .WithMany(p => p.SyncQueue)
                    .HasForeignKey(d => d.SyncDownQueueId)
                    .HasConstraintName("FK_SyncQueue_SyncDownQueue");

                entity.HasOne(d => d.SyncUpQueue)
                    .WithMany(p => p.SyncQueue)
                    .HasForeignKey(d => d.SyncUpQueueId)
                    .HasConstraintName("FK_SyncQueue_SyncUpQueue");
            });

            modelBuilder.Entity<SyncTables>(entity =>
            {
                entity.HasKey(e => e.TableId);

                entity.ToTable("SyncTables", "Sync");

                entity.Property(e => e.TableId)
                    .HasColumnName("TableID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyncUpBatch>(entity =>
            {
                entity.HasKey(e => e.BatchId);

                entity.ToTable("SyncUpBatch", "Sync");

                entity.HasIndex(e => e.BatchStatusId)
                    .HasName("ixSyncUpBatch_Status")
                    .IsUnique()
                    .HasFilter("([BatchStatusId]=(1))");

                entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastChangeDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SyncUpBatchStatus>(entity =>
            {
                entity.HasKey(e => e.BatchStatusId);

                entity.ToTable("SyncUpBatchStatus", "Sync");

                entity.Property(e => e.BatchStatusId).ValueGeneratedNever();

                entity.Property(e => e.BatchStatusDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyncUpQueue>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("SyncUpQueue", "Sync");

                entity.HasIndex(e => e.BatchId)
                    .HasName("ixSyncUpQueue_BatchId");

                entity.Property(e => e.DataXml).HasColumnName("DataXML");

                entity.Property(e => e.OperationType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.ToTable("Tax", "SM");

                entity.Property(e => e.TaxId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Glcode)
                    .IsRequired()
                    .HasColumnName("GLCode")
                    .HasMaxLength(12);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CalculationTypeNavigation)
                    .WithMany(p => p.Tax)
                    .HasForeignKey(d => d.CalculationType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tax_TaxCalculationTypes");
            });

            modelBuilder.Entity<TaxCalculationTypes>(entity =>
            {
                entity.HasKey(e => e.CalculationType);

                entity.ToTable("TaxCalculationTypes", "SM");

                entity.Property(e => e.CalculationType).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(32);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TaxRates>(entity =>
            {
                entity.HasKey(e => new { e.TaxId, e.VersionDate });

                entity.ToTable("TaxRates", "SM");

                entity.HasIndex(e => e.TaxRateId)
                    .HasName("IX_TaxRates")
                    .IsUnique();

                entity.Property(e => e.VersionDate).HasColumnType("datetime");

                entity.Property(e => e.LaborRate).HasColumnType("decimal(18, 12)");

                entity.Property(e => e.MatlRate).HasColumnType("decimal(18, 12)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.TaxRateId).ValueGeneratedOnAdd();

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.TaxRates)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaxRates_Tax");
            });

            modelBuilder.Entity<TechRole>(entity =>
            {
                entity.ToTable("TechRole", "SM");

                entity.HasIndex(e => e.Description)
                    .HasName("TechRole_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.TechRoleId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(21);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TireMarkup>(entity =>
            {
                entity.ToTable("TireMarkup", "SM");

                entity.Property(e => e.Percentage).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.ToTable("TransactionType", "SM");

                entity.HasIndex(e => e.Code)
                    .HasName("IX_TransactionType_Code")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Transmission>(entity =>
            {
                entity.ToTable("Transmission", "DMV");

                entity.Property(e => e.TransmissionId).ValueGeneratedNever();

                entity.Property(e => e.ControlType).HasMaxLength(50);

                entity.Property(e => e.ManufacturerCode).HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransmissionType).HasMaxLength(50);
            });

            modelBuilder.Entity<UpdatesAvailable>(entity =>
            {
                entity.ToTable("UpdatesAvailable", "Sync");

                entity.HasIndex(e => e.FileName)
                    .HasName("ucUpdateAvailableName")
                    .IsUnique();

                entity.Property(e => e.Dependency).HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.FileCrc).HasColumnName("FileCRC");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PreviousVersion).HasMaxLength(20);

                entity.Property(e => e.ReportStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.InstallationStatusNavigation)
                    .WithMany(p => p.UpdatesAvailable)
                    .HasForeignKey(d => d.InstallationStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UpdatesAvailable_UpdatesInstallStatus");
            });

            modelBuilder.Entity<UpdatesInstallStatus>(entity =>
            {
                entity.HasKey(e => e.InstallStatusId);

                entity.ToTable("UpdatesInstallStatus", "Sync");

                entity.Property(e => e.InstallStatusId).ValueGeneratedNever();

                entity.Property(e => e.InstallStatusDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Users", "SM");

                entity.Property(e => e.AccessRights)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<UserVehicleAttributes>(entity =>
            {
                entity.HasKey(e => e.UserAttributeId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("UserVehicleAttributes", "SM");

                entity.HasIndex(e => new { e.VehicleId, e.AttributeName })
                    .HasName("IX_UserVehicleAttributes")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AttributeValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ymmselector).HasColumnName("YMMSelector");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.UserVehicleAttributes)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_UserVehicleAttributes_Vehicle");
            });

            modelBuilder.Entity<Vdoc>(entity =>
            {
                entity.HasKey(e => e.GlobalVdocId);

                entity.ToTable("VDoc", "SM");

                entity.HasIndex(e => e.GlobalVdocId);

                entity.HasIndex(e => e.LocalRepairOrderId);

                entity.Property(e => e.GlobalVdocId)
                    .HasColumnName("GlobalVDocID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastOpened).HasColumnType("datetime");

                entity.Property(e => e.DateLastSaved)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocalRepairOrderId).HasColumnName("LocalRepairOrderID");

                entity.Property(e => e.LocalVdocId)
                    .HasColumnName("LocalVDocID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SectionCvd)
                    .HasColumnName("SectionCVD")
                    .HasColumnType("xml")
                    .HasDefaultValueSql("('<VDocSection Name=\"CVD\"/>')");

                entity.Property(e => e.SectionGeneric)
                    .HasColumnType("xml")
                    .HasDefaultValueSql("('<VDocSection Name=\"GENERIC\"/>')");

                entity.Property(e => e.SectionPcodes)
                    .HasColumnName("SectionPCodes")
                    .HasColumnType("xml")
                    .HasDefaultValueSql("('<VDocSection Name=\"PCODES\"/>')");

                entity.Property(e => e.SectionTechview)
                    .HasColumnType("xml")
                    .HasDefaultValueSql("('<VDocSection Name=\"TECHVIEW\"/>')");

                entity.Property(e => e.SectionTrace)
                    .HasColumnType("xml")
                    .HasDefaultValueSql("('<VDocSection Name=\"TRACE\"/>')");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LocalRepairOrder)
                    .WithMany(p => p.Vdoc)
                    .HasForeignKey(d => d.LocalRepairOrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VDoc_RepairOrder");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("Vehicle", "SM");

                entity.HasIndex(e => e.BodyId);

                entity.HasIndex(e => e.BrakeId);

                entity.HasIndex(e => e.CustId)
                    .HasName("IX_Vehicle_CustId_License");

                entity.HasIndex(e => e.DriveTypeId);

                entity.HasIndex(e => e.EngineId);

                entity.HasIndex(e => e.Gvwid);

                entity.HasIndex(e => e.MakeId);

                entity.HasIndex(e => e.SubModelId);

                entity.HasIndex(e => e.TransmissionId);

                entity.HasIndex(e => new { e.VehicleId, e.Deleted })
                    .HasName("Vehicle_Deleted_Index");

                entity.HasIndex(e => new { e.VehicleId, e.EngineId, e.Deleted })
                    .HasName("Vehicle_EngineId_Index");

                entity.HasIndex(e => new { e.VehicleId, e.TransmissionId, e.Deleted })
                    .HasName("Vehicle_TransmissionId_Index");

                entity.Property(e => e.VehicleId).HasDefaultValueSql("(NEXT VALUE FOR [SM].[VehicleSequence])");

                entity.Property(e => e.ActiveRecallLastChecked).HasColumnType("datetime");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DriverName).HasMaxLength(71);

                entity.Property(e => e.EngineHoursIn).HasColumnType("decimal(7, 1)");

                entity.Property(e => e.EngineHoursOut).HasColumnType("decimal(7, 1)");

                entity.Property(e => e.Gvwid).HasColumnName("GVWId");

                entity.Property(e => e.IncludeInCrmcampaign)
                    .IsRequired()
                    .HasColumnName("IncludeInCRMCampaign")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InspDate).HasColumnType("datetime");

                entity.Property(e => e.LastInDate).HasColumnType("datetime");

                entity.Property(e => e.License)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LicenseState)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MfgDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.UnitNo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VehicleClass).HasDefaultValueSql("((1))");

                entity.Property(e => e.VehicleMemo).HasDefaultValueSql("('')");

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Body)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.BodyId)
                    .HasConstraintName("FK_Vehicle_BodyStyle");

                entity.HasOne(d => d.Brake)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.BrakeId)
                    .HasConstraintName("FK_Vehicle_Brake");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Vehicle_Customers");

                entity.HasOne(d => d.DriveType)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.DriveTypeId)
                    .HasConstraintName("FK_Vehicle_Drive");

                entity.HasOne(d => d.DriverPhone)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.DriverPhoneId)
                    .HasConstraintName("FK_Vehicle_DriverPhone");

                entity.HasOne(d => d.Engine)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.EngineId)
                    .HasConstraintName("FK_Vehicle_Engine");

                entity.HasOne(d => d.Gvw)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.Gvwid)
                    .HasConstraintName("FK_Vehicle_Gvw");

                entity.HasOne(d => d.LaborLevelNavigation)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.LaborLevel)
                    .HasConstraintName("FK_Vehicle_LaborRateDescription");

                entity.HasOne(d => d.Make)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.MakeId)
                    .HasConstraintName("FK_Vehicle_Make");

                entity.HasOne(d => d.PartLevelNavigation)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.PartLevel)
                    .HasConstraintName("FK_Vehicle_PartDiscountDescription");

                entity.HasOne(d => d.SubModel)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.SubModelId)
                    .HasConstraintName("FK_Vehicle_SubModel");

                entity.HasOne(d => d.Transmission)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.TransmissionId)
                    .HasConstraintName("FK_Vehicle_Transmission");

                entity.HasOne(d => d.YearNavigation)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.Year)
                    .HasConstraintName("FK_Vehicle_Year");
            });

            modelBuilder.Entity<VehicleConfigurationMapping>(entity =>
            {
                entity.HasKey(e => e.VehicleConfigurationId);

                entity.ToTable("VehicleConfigurationMapping", "DMV");

                entity.HasIndex(e => e.ShopMgtVehicleConfigId)
                    .HasName("IX_VehicleConfigurationMapping");

                entity.Property(e => e.VehicleConfigurationId).ValueGeneratedNever();

                entity.HasOne(d => d.ShopMgtVehicleConfig)
                    .WithMany(p => p.VehicleConfigurationMapping)
                    .HasForeignKey(d => d.ShopMgtVehicleConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleConfigurationMapping_ShopMgtVehicleConfig");
            });

            modelBuilder.Entity<VehicleLocation>(entity =>
            {
                entity.ToTable("VehicleLocation", "SM");

                entity.HasIndex(e => e.Location)
                    .HasName("VehicleLocation_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<VehicleNotes>(entity =>
            {
                entity.HasKey(e => new { e.VehicleId, e.VehicleNoteTypeId });

                entity.ToTable("VehicleNotes", "SM");

                entity.Property(e => e.NoteText)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehicleNotes)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_VehicleNotes_Vehicle");

                entity.HasOne(d => d.VehicleNoteType)
                    .WithMany(p => p.VehicleNotes)
                    .HasForeignKey(d => d.VehicleNoteTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleNotes_VehicleNoteTypes");
            });

            modelBuilder.Entity<VehicleNoteTypes>(entity =>
            {
                entity.HasKey(e => e.VehicleNoteTypeId);

                entity.ToTable("VehicleNoteTypes", "SM");

                entity.Property(e => e.VehicleNoteTypeId).ValueGeneratedNever();

                entity.Property(e => e.NoteLabel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<VehicleTaxes>(entity =>
            {
                entity.HasKey(e => new { e.VehicleId, e.TaxId });

                entity.ToTable("VehicleTaxes", "SM");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.VehicleTaxes)
                    .HasForeignKey(d => d.TaxId)
                    .HasConstraintName("FK_VehicleTaxes_Tax");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehicleTaxes)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_VehicleTaxes_Vehicle");
            });

            modelBuilder.Entity<VehicleTelemetry>(entity =>
            {
                entity.ToTable("VehicleTelemetry", "SM");

                entity.Property(e => e.BatteryVoltage).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.Latitude).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Submitted).HasColumnType("datetime");

                entity.HasOne(d => d.ConnectedVehicleProvider)
                    .WithMany(p => p.VehicleTelemetry)
                    .HasForeignKey(d => d.ConnectedVehicleProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleTelemetry_ConnectedVehicleProvider");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor", "SM");

                entity.HasIndex(e => e.CatalogLinkId);

                entity.HasIndex(e => e.VendorTypeId);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Comment).HasDefaultValueSql("('')");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.Limit).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Terms)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CatalogLink)
                    .WithMany(p => p.Vendor)
                    .HasForeignKey(d => d.CatalogLinkId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Vendor_CatalogLink");

                entity.HasOne(d => d.VendorType)
                    .WithMany(p => p.Vendor)
                    .HasForeignKey(d => d.VendorTypeId)
                    .HasConstraintName("FK_Vendor_VendorType");
            });

            modelBuilder.Entity<VendorAddresses>(entity =>
            {
                entity.HasKey(e => new { e.VendorId, e.AddressId });

                entity.ToTable("VendorAddresses", "SM");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.VendorAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_VendorAddresses_Addresses");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorAddresses)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_VendorAddresses_Vendor");
            });

            modelBuilder.Entity<VendorLink>(entity =>
            {
                entity.HasKey(e => new { e.VendorId, e.Property });

                entity.ToTable("VendorLink", "SM");

                entity.Property(e => e.Property).HasMaxLength(256);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorLink)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorLink_Vendor");
            });

            modelBuilder.Entity<VendorPhones>(entity =>
            {
                entity.HasKey(e => new { e.VendorId, e.PhoneId });

                entity.ToTable("VendorPhones", "SM");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.VendorPhones)
                    .HasForeignKey(d => d.PhoneId)
                    .HasConstraintName("FK_VendorPhones_PhoneNum");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorPhones)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_VendorPhones_Vendor");
            });

            modelBuilder.Entity<VendorType>(entity =>
            {
                entity.ToTable("VendorType", "SM");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.HasKey(e => e.DmvversionDate);

                entity.ToTable("Version", "DMV");

                entity.Property(e => e.DmvversionDate)
                    .HasColumnName("DMVVersionDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.VersionNumber).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Vinmapping>(entity =>
            {
                entity.HasKey(e => new { e.Vincode, e.VehicleConfigurationId });

                entity.ToTable("VINMapping", "DMV");

                entity.Property(e => e.Vincode)
                    .HasColumnName("VINCode")
                    .HasMaxLength(17);

                entity.Property(e => e.VehicleConfigurationId).HasColumnName("VehicleConfigurationID");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.VehicleConfiguration)
                    .WithMany(p => p.Vinmapping)
                    .HasForeignKey(d => d.VehicleConfigurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VINMapping_VehicleConfigurationMapping");
            });

            modelBuilder.Entity<Year>(entity =>
            {
                entity.HasKey(e => e.Year1);

                entity.ToTable("Year", "DMV");

                entity.Property(e => e.Year1)
                    .HasColumnName("Year")
                    .ValueGeneratedNever();

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ZipCode>(entity =>
            {
                entity.ToTable("ZipCode", "SM");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Zipcode1)
                    .IsRequired()
                    .HasColumnName("Zipcode")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ZipCodeAlternate>(entity =>
            {
                entity.ToTable("ZipCodeAlternate", "SM");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.RecordVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.HasSequence<int>("CustomersSequence")
                .StartsAt(6721)
                .HasMin(0);

            modelBuilder.HasSequence<int>("POMasterSequence")
                .StartsAt(18006)
                .HasMin(0);

            modelBuilder.HasSequence<int>("RecordNumberSequence")
                .StartsAt(51847)
                .HasMin(0);

            modelBuilder.HasSequence<int>("RepairOrderSequence")
                .StartsAt(89231)
                .HasMin(0);

            modelBuilder.HasSequence<int>("VehicleSequence")
                .StartsAt(11149)
                .HasMin(0);
        }
    }
}
