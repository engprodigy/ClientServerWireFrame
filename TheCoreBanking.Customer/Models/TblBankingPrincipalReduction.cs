using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingPrincipalReduction
    {
        public int Id { get; set; }
        public string CustCode { get; set; }
        public string ProductAcctNo { get; set; }
        public int? Instalment { get; set; }
        public int? InstalmentLeft { get; set; }
        public decimal? OutprincipalBal { get; set; }
        public decimal? AccruedInterest { get; set; }
        public decimal? AmountReduced { get; set; }
        public decimal? OldPrincipal { get; set; }
        public decimal? NewPrincipal { get; set; }
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
        public string AccountId { get; set; }
        public string CreatedBy { get; set; }
        public bool? PayInterest { get; set; }
        public decimal? ExcessInterest { get; set; }
        public decimal? PrincipalFrequency { get; set; }
        public string PrincipalFreqType { get; set; }
        public decimal? FixedPrincipal { get; set; }
        public string BatchRef { get; set; }
        public decimal? ArchivedPrincipal { get; set; }
        public bool? InterestStatus { get; set; }
        public decimal? PastDueInterest { get; set; }
    }
}
