using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingSecurityWorth
    {
        public long Id { get; set; }
        public string SecName { get; set; }
        public string SecId { get; set; }
        public decimal? SecWorth { get; set; }
        public decimal? AmountUsed { get; set; }
        public decimal? AmountRemaining { get; set; }
        public DateTime? TransDate { get; set; }
        public string CreatedBy { get; set; }
        public string CustCode { get; set; }
        public string Upload { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public bool? Disapproved { get; set; }
        public string CoyCode { get; set; }
        public string BrCode { get; set; }
        public string ApprovalComment { get; set; }
        public string Remark { get; set; }
        public string CustName { get; set; }
        public bool? Used { get; set; }
    }
}
