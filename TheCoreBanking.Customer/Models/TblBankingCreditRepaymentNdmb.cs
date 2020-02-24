using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingCreditRepaymentNdmb
    {
        public int Id { get; set; }
        public string CustCode { get; set; }
        public string ProductAcctNo { get; set; }
        public string ProdCode { get; set; }
        public decimal? PrincipalRepayment { get; set; }
        public decimal? InterestRepayment { get; set; }
        public decimal? TotalRepayment { get; set; }
        public decimal? DefaultChargedPaid { get; set; }
        public decimal? FeePaid { get; set; }
        public DateTime? DatePaid { get; set; }
        public bool? Running { get; set; }
        public bool? Approved { get; set; }
        public bool? Disapproved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public int? OperationId { get; set; }
        public string BatchRef { get; set; }
        public string CoyCode { get; set; }
        public string BrCode { get; set; }
        public string CreatedBy { get; set; }
        public string Remark { get; set; }
        public decimal? AmountPaid { get; set; }
    }
}
