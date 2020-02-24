using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingProductFeesListLoanMapping
    {
        public int Id { get; set; }
        public string CustCode { get; set; }
        public int? ProductId { get; set; }
        public string ProductAcctNo { get; set; }
        public int? FeesId { get; set; }
        public string FeesName { get; set; }
        public bool? SelectedFee { get; set; }
        public string Rate { get; set; }
        public decimal? FeeValue { get; set; }
    }
}
