using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingChangeRepaymentDate
    {
        public int Id { get; set; }
        public string CustCode { get; set; }
        public string ProductAcctNo { get; set; }
        public DateTime? OldRepaymentDate { get; set; }
        public DateTime? NewRepaymentDate { get; set; }
        public int? DayDiff { get; set; }
        public decimal? OutprincipalBal { get; set; }
        public decimal? AccruedInterest { get; set; }
        public int? OperationId { get; set; }
        public string Remark { get; set; }
        public bool? Approved { get; set; }
        public bool? Disapproved { get; set; }
        public DateTime? DateApproved { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovalRemark { get; set; }
        public string CoyCode { get; set; }
        public string BrCode { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
