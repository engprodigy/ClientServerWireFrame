using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAppraisalUserLevelMapping
    {
        public int LevelUserId { get; set; }
        public int? LevelId { get; set; }
        public string UserId { get; set; }
        public string LevelName { get; set; }
        public string BranchId { get; set; }
        public string CoyId { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string CreatedBy { get; set; }
    }
}
