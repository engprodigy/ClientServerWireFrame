using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TsCreditType
    {
        public int CreditTypeId { get; set; }
        public string CreditType { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string CoyId { get; set; }
        public string BranchId { get; set; }
        public string PdCode { get; set; }
    }
}
