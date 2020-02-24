using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAppraisalStatus
    {
        public int AppraisalStatusId { get; set; }
        public string CreditAccountNo { get; set; }
        public int PhaseId { get; set; }
        public int PreviousLevelId { get; set; }
        public int CurrentLevelId { get; set; }
        public int StatusId { get; set; }
        public string MadeBy { get; set; }
        public string CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public string DateUpdated { get; set; }
        public string TimeUpdated { get; set; }
        public string Comment { get; set; }
    }
}
