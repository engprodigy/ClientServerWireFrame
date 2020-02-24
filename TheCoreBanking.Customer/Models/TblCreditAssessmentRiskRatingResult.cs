using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAssessmentRiskRatingResult
    {
        public int ResultId { get; set; }
        public string ProductCode { get; set; }
        public string LoanNumber { get; set; }
        public int RiskId { get; set; }
        public decimal RiskWeight { get; set; }
        public int FactorIndexId { get; set; }
        public decimal FactorWeight { get; set; }
        public int IndexTitleId { get; set; }
        public decimal IndexTitleMaximumWeight { get; set; }
        public decimal IndexTitleWeight { get; set; }
        public int AssessmentIndexId { get; set; }
        public decimal Score { get; set; }
        public decimal CalculatedScore { get; set; }
        public DateTime DateofRating { get; set; }
        public string Ratedby { get; set; }
    }
}
