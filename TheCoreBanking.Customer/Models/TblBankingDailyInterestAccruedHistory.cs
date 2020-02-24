using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingDailyInterestAccruedHistory
    {
        public int Id { get; set; }
        public DateTime? DDate { get; set; }
        public string DealId1 { get; set; }
        public decimal? IPrincipal { get; set; }
        public decimal? InterestRate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public decimal? IAccrualTodate { get; set; }
        public decimal? Iptday { get; set; }
        public decimal? Iptdate { get; set; }
        public DateTime? LastEod { get; set; }
        public decimal? InterestAmount { get; set; }
        public int? NoOfDays { get; set; }
        public bool? Scheduled { get; set; }
        public DateTime? TransDate { get; set; }
    }
}
