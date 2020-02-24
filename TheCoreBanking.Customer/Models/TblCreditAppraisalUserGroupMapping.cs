using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAppraisalUserGroupMapping
    {
        public int UserGroupId { get; set; }
        public int? GroupId { get; set; }
        public string UserId { get; set; }
        public string GroupName { get; set; }
        public string UserName { get; set; }
        public string BranchId { get; set; }
        public string CoyId { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string CreatedBy { get; set; }
    }
}
