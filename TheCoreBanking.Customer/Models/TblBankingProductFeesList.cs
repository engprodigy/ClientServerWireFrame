using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingProductFeesList
    {
        public int Id { get; set; }
        public int? PdId { get; set; }
        public int? PdFeesId { get; set; }
        public decimal? RateValue { get; set; }
        public string PdFeesName { get; set; }
        public bool? PdRate { get; set; }
        public decimal? FeeValue { get; set; }
    }
}
