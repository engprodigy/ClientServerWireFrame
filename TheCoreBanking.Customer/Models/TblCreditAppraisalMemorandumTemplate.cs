using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAppraisalMemorandumTemplate
    {
        public int TemplateId { get; set; }
        public string ProductCode { get; set; }
        public string Memorandum { get; set; }
        public string TemplatePath { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
    }
}
