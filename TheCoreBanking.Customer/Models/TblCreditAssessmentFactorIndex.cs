using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAssessmentFactorIndex
    {
        public int FactorIndexId { get; set; }
        public string FactorIndexDescription { get; set; }
        public int? Weight { get; set; }
        public int? RiskFactorId { get; set; }
        public string ProductCode { get; set; }
    }
}
