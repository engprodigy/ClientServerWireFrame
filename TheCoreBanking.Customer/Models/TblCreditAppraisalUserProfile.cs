using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAppraisalUserProfile
    {
        public int UserProfileId { get; set; }
        public int UserId { get; set; }
        public int ProfileId { get; set; }
        public string UserName { get; set; }
        public string ProfileName { get; set; }
    }
}
