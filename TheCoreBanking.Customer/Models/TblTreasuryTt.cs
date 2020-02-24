using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblTreasuryTt
    {
        public string TransactionId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Ref { get; set; }
        public string CpId { get; set; }
        public string Description { get; set; }
        public double? DVolume { get; set; }
        public double? CVolume { get; set; }
        public double? DebitAmount { get; set; }
        public double? CreditAmount { get; set; }
        public string UserName { get; set; }
        public double? TransactionType { get; set; }
        public double? AcctTransaction { get; set; }
        public string CustCode { get; set; }
        public string ProductCode { get; set; }
        public double? Branch { get; set; }
        public double? Coy { get; set; }
        public string FormNo { get; set; }
        public string BatchRef { get; set; }
        public DateTime? PostDate { get; set; }
        public string ApplicationId { get; set; }
        public double? Approved { get; set; }
        public double? Show { get; set; }
        public double? IsReversed { get; set; }
        public string GlaccountId { get; set; }
        public double? IsRepayment { get; set; }
    }
}
