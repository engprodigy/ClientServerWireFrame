using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingLoanChecklist
    {
        public int Id { get; set; }
        public string DeptCode { get; set; }
        public string Dept { get; set; }
        public string Checklist { get; set; }
        public string CoyCode { get; set; }
        public string BrCode { get; set; }
        public DateTime? Ddate { get; set; }
        public string CreatedBy { get; set; }
        public bool? ChecklistItem { get; set; }
    }
}
