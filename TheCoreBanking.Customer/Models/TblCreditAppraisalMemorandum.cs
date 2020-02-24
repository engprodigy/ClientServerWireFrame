using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAppraisalMemorandum
    {
        public int MemoId { get; set; }
        public string ProductCode { get; set; }
        public string LoanAccountNo { get; set; }
        public string Memorandum { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string LastUpdateBy { get; set; }
        public string LastUpdateOn { get; set; }
    }
}
