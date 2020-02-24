using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingAccumulatedInterestHistory
    {
        public int Id { get; set; }
        public DateTime? DDate { get; set; }
        public string Productacctno { get; set; }
        public decimal? PrincipalBalance { get; set; }
        public decimal? InterestRate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public decimal? AccumulatedInterest { get; set; }
        public decimal? PeriodicInterest { get; set; }
        public DateTime? LastDefaultDate { get; set; }
        public DateTime? TransDate { get; set; }
        public string Operation { get; set; }
    }
}
