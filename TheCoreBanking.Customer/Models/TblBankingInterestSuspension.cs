using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingInterestSuspension
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Principal { get; set; }
        public string LastIntPaid { get; set; }
        public string DatePaid { get; set; }
        public int? Tenor { get; set; }
        public int? Moratorium { get; set; }
        public int? Instalment { get; set; }
        public string Interest { get; set; }
        public string ProductName { get; set; }
        public string CustCode { get; set; }
        public string ProdCode { get; set; }
        public DateTime? DateSuspended { get; set; }
        public string CoyCode { get; set; }
        public bool? ApprovedAdvance { get; set; }
        public bool? ApprovedLease { get; set; }
        public bool? ApprovedLoan { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public string Remark { get; set; }
        public string LastPrincipalPaid { get; set; }
        public int? InstalmentLeft { get; set; }
        public string ProductAccNo { get; set; }
        public string BranchId { get; set; }
        public int? OperationId { get; set; }
        public bool? DisapprovedAdvance { get; set; }
        public bool? DisapprovedLease { get; set; }
        public bool? DisapprovedLoan { get; set; }
        public string ProductType { get; set; }
        public string MisCode { get; set; }
        public string Comment { get; set; }
    }
}
