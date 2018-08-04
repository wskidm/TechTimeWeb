using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Schedule
    {
        public Schedule()
        {
            Alert = new HashSet<Alert>();
            ScheduleCannedJob = new HashSet<ScheduleCannedJob>();
        }

        public int ScheduleId { get; set; }
        public int? CustId { get; set; }
        public int? VehicleId { get; set; }
        public int? RepairOrderId { get; set; }
        public int StatusId { get; set; }
        public int? EmployeeId { get; set; }
        public int? ResourceId { get; set; }
        public int? ReasonForVisitId { get; set; }
        public int? PrimaryCustomerPhoneId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Subject { get; set; }
        public string Notes { get; set; }
        public bool PrintOnOrder { get; set; }
        public int? ReminderDate { get; set; }
        public bool AllDayEvent { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? PromisedDate { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime? DropOffDate { get; set; }
        public bool? AutoAdjust { get; set; }
        public int RecordVersion { get; set; }
        public int? ServiceWriterId { get; set; }
        public string CustomerNotes { get; set; }
        public bool CustomerNotesPrintOnOrder { get; set; }
        public bool MatchStartTime { get; set; }

        public Category Category { get; set; }
        public Customers Cust { get; set; }
        public Employee Employee { get; set; }
        public CustomerPhones PrimaryCustomerPhone { get; set; }
        public ReasonForVisit ReasonForVisit { get; set; }
        public RepairOrder RepairOrder { get; set; }
        public ScheduleResource Resource { get; set; }
        public Employee ServiceWriter { get; set; }
        public ScheduleStatus Status { get; set; }
        public Vehicle Vehicle { get; set; }
        public ICollection<Alert> Alert { get; set; }
        public ICollection<ScheduleCannedJob> ScheduleCannedJob { get; set; }
    }
}
