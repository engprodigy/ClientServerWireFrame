using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAssessmentIndexTitle
    {
        public int IndexTitleId { get; set; }
        public string IndexTitleDescription { get; set; }
        public int? Weight { get; set; }
        public int FactorIndexId { get; set; }
        public string ProductCode { get; set; }
    }
}
