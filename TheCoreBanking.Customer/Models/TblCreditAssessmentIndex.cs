using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAssessmentIndex
    {
        public int IndexId { get; set; }
        public string AssessmentIndex { get; set; }
        public int? Weight { get; set; }
        public int? IndexTitleId { get; set; }
        public string ProductCode { get; set; }
    }
}
