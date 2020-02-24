using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAppraisalGrade
    {
        public int CreditGradeId { get; set; }
        public string CreditGrade { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string CoyId { get; set; }
        public string BranchId { get; set; }
    }
}
