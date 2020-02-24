using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblTempBankingUpdateSchedule
    {
        public int Id { get; set; }
        public int? Month { get; set; }
        public int? NoOfDays { get; set; }
        public decimal? PrincipalBalance { get; set; }
        public DateTime? NextPayDay { get; set; }
        public decimal? InterestAccrual { get; set; }
        public decimal? InterestPayment { get; set; }
        public decimal? PrincipalRepayment { get; set; }
        public decimal? TotalRepayment { get; set; }
        public string CustCode { get; set; }
        public string ProductAcctNo { get; set; }
        public string ProductName { get; set; }
        public string PdTypeId { get; set; }
        public string CoyCode { get; set; }
        public string BranchCode { get; set; }
        public string ProdCode { get; set; }
        public string CurrentAcct { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        public string CustName { get; set; }
        public string CoyClass { get; set; }
        public bool? InterestCalculated { get; set; }
        public decimal? EndBalance { get; set; }
        public string Ref { get; set; }
        public bool? Active { get; set; }
        public decimal? FeeCharged { get; set; }
        public decimal? CummulativeInterest { get; set; }
        public decimal? CummulativePrinRepyt { get; set; }
        public bool? Paid { get; set; }
    }
}
