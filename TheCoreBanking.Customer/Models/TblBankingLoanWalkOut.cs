using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingLoanWalkOut
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustCode { get; set; }
        public string ProductAccNo { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal? PrincipalRecapitalised { get; set; }
        public decimal? InterestCapitalised { get; set; }
        public decimal? Principal { get; set; }
        public decimal? NewPrincipal { get; set; }
        public decimal? InterestAccrual { get; set; }
        public decimal? OutstandingPrincipal { get; set; }
        public int? OldTenor { get; set; }
        public int? Tenor { get; set; }
        public decimal? OldRate { get; set; }
        public decimal? Rate { get; set; }
        public int? Instalment { get; set; }
        public bool? ApprovedAdvance { get; set; }
        public bool? ApprovedLease { get; set; }
        public bool? ApprovedLoan { get; set; }
        public string Approvedby { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? TerminalDate { get; set; }
        public string Remark { get; set; }
        public string BranchId { get; set; }
        public decimal? LoanWalkOut { get; set; }
        public bool? DisapprovedAdvance { get; set; }
        public bool? DisapprovedLease { get; set; }
        public bool? DisapprovedLoan { get; set; }
        public int? OperationId { get; set; }
        public string ProductType { get; set; }
        public string MisCode { get; set; }
        public string CoyCode { get; set; }
        public string Comment { get; set; }
    }
}
