using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAppraisalLevel
    {
        public int LevelId { get; set; }
        public int? GroupId { get; set; }
        public string LevelName { get; set; }
        public string CoyId { get; set; }
        public string BranchId { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
