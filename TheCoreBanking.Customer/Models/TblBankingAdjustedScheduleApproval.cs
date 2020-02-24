using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingAdjustedScheduleApproval
    {
        public int Id { get; set; }
        public string ProductAcctNo { get; set; }
        public string Product { get; set; }
        public string CustCode { get; set; }
        public string Customer { get; set; }
        public decimal? OutstandingPrin { get; set; }
        public string AdjustedBy { get; set; }
        public DateTime? DateAdjusted { get; set; }
        public int? OperationId { get; set; }
        public bool? Approved { get; set; }
        public bool? Disapproved { get; set; }
        public string Approvedby { get; set; }
        public string ApprovalRemark { get; set; }
        public DateTime? DateApproved { get; set; }
        public string CoyCode { get; set; }
        public string BrCode { get; set; }
    }
}
