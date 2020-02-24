using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAssessmentRiskRating
    {
        public int RiskRatingId { get; set; }
        public decimal? MaximumScore { get; set; }
        public decimal? MinimumScore { get; set; }
        public string RiskRating { get; set; }
        public string RiskRatingRemarks { get; set; }
        public string InterestRate { get; set; }
        public string CoyCode { get; set; }
        public string BrCode { get; set; }
        public int? CreditTypeId { get; set; }
        public string CreditGrades { get; set; }
        public string CreditGradeDefinitions { get; set; }
        public string PdCode { get; set; }
        public string CreditGradeDesc { get; set; }
    }
}
