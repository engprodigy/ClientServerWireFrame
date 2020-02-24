using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblMaintenanceaccountdetails
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string Branch { get; set; }
        public string Product { get; set; }
        public string RelationshipOfficer { get; set; }
        public decimal? InterestCharge { get; set; }
        public bool? Ibanking { get; set; }
        public bool? Atmbanking { get; set; }
        public bool? Mbanking { get; set; }
        public bool? EmailAlert { get; set; }
        public bool? Smsalert { get; set; }
        public bool? Approved { get; set; }
        public bool? Disapproved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public string CreatedBy { get; set; }
        public int? OpCode { get; set; }
        public string Coycode { get; set; }
        public string AccountNo { get; set; }
        public string RelationshipOfficerName { get; set; }
        public string Pccode { get; set; }
        public string ProductName { get; set; }
        public string RelationshipManager { get; set; }
        public string MgrPccode { get; set; }
    }
}
