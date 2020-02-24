using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblScheduleSimulation
    {
        public int Id { get; set; }
        public int? Tenor { get; set; }
        public decimal? InterestRate { get; set; }
        public double? Principal { get; set; }
        public DateTime? Startdate { get; set; }
        public int? Moratorium { get; set; }
        public double? NumOfInstalment { get; set; }
        public string CustCode { get; set; }
        public string ProductAcctNo { get; set; }
        public string CoyCode { get; set; }
        public string BranchCode { get; set; }
        public int? Dd { get; set; }
        public decimal? Frequency { get; set; }
        public int? BulletFrq { get; set; }
        public int? BulletType { get; set; }
        public int? TenorMode { get; set; }
        public bool? WithInterest { get; set; }
        public DateTime? FirstPayDate { get; set; }
        public decimal? Fee { get; set; }
        public int? FreqOfFee { get; set; }
        public bool? SetEqualDate { get; set; }
        public DateTime? TerminalDate { get; set; }
        public bool? Eop { get; set; }
        public decimal? PrincipalFrequency { get; set; }
        public decimal? FixedPrincipal { get; set; }
    }
}
