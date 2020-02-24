using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingOperativeAccounts
    {
        public int Id { get; set; }
        public string CustCode { get; set; }
        public string ProductAccountNo { get; set; }
        public string OldOperativeAccount { get; set; }
        public decimal? Amount { get; set; }
        public string NewOperativeAccount { get; set; }
        public string NewAccountId { get; set; }
        public decimal? NewAmount { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        public int? OperationId { get; set; }
        public bool? Approved { get; set; }
        public bool? Disapproved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public string CoyCode { get; set; }
        public string BrCode { get; set; }
        public string Comment { get; set; }
        public string AprovalRemark { get; set; }
    }
}
