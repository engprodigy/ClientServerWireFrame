using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingCreditArchivedInterest
    {
        public int Id { get; set; }
        public string CustCode { get; set; }
        public string ProductAcctNo { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? TransDate { get; set; }
        public string CreatedBy { get; set; }
        public bool? Active { get; set; }
        public string CoyCode { get; set; }
        public string BrCode { get; set; }
        public bool? Approved { get; set; }
        public decimal? PrincipalAmount { get; set; }
        public decimal? ArchivedInterest { get; set; }
    }
}
