using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingCustomerFees
    {
        public int Id { get; set; }
        public string CustCode { get; set; }
        public int? ProductId { get; set; }
        public string ProductAcctNo { get; set; }
        public int? FeesId { get; set; }
        public string FeesSchedule { get; set; }
        public int? MyCount { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CoyCode { get; set; }
        public string BranchId { get; set; }
        public string Miscode { get; set; }
        public bool? SelectedFee { get; set; }
        public string Rate { get; set; }
        public decimal? FeeValue { get; set; }
        public bool? Charged { get; set; }
    }
}
