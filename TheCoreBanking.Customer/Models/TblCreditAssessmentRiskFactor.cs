using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAssessmentRiskFactor
    {
        public int RiskFactorId { get; set; }
        public string RiskFactorsDescription { get; set; }
        public int? Weight { get; set; }
        public string CoyId { get; set; }
        public string BranchId { get; set; }
        public string ProductCode { get; set; }
    }
}
