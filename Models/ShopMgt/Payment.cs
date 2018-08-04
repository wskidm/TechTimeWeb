using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int? RepairOrderId { get; set; }
        public int? RecordNumber { get; set; }
        public int? CustomerId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string CheckData { get; set; }
        public string AuthData { get; set; }
        public decimal Amount { get; set; }
        public int InvoiceStatusId { get; set; }
        public bool? IsNsf { get; set; }
        public bool? IsNsfreversal { get; set; }
        public bool? IsFeePayment { get; set; }
        public decimal? TotalPayment { get; set; }
        public DateTime? DeletionDate { get; set; }
        public int PaymentTransactionId { get; set; }
        public int? AccountClassId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }
        public byte[] VerificationData { get; set; }
        public string ReceiptOne { get; set; }
        public string ReceiptTwo { get; set; }
        public string ReceiptThree { get; set; }

        public AccountClass AccountClass { get; set; }
        public Customers Customer { get; set; }
        public InvoiceStatus InvoiceStatus { get; set; }
        public PaymentTransaction PaymentTransaction { get; set; }
        public RepairOrder RepairOrder { get; set; }
    }
}
