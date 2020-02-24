using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAppraisalGroupProfile
    {
        public int GroupProfileId { get; set; }
        public int GroupId { get; set; }
        public int ProfileId { get; set; }
        public string GroupName { get; set; }
        public string ProfileName { get; set; }
    }
}
