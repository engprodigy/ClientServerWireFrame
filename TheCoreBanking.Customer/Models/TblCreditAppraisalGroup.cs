using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAppraisalGroup
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public bool? IsActive { get; set; }
        public string CoyId { get; set; }
        public string BranchId { get; set; }
        public DateTime? LastUpdate { get; set; }
        public bool? IsCommittee { get; set; }
        public int? PhaseId { get; set; }
    }
}
