using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingProductSecurity
    {
        public int PdSecId { get; set; }
        public string PdSecurity { get; set; }
        public decimal? HairCut { get; set; }
        public DateTime? ModDate { get; set; }
        public bool? Active { get; set; }
        public string Remark { get; set; }
        public string CreatedBy { get; set; }
        public string SecType { get; set; }
        public string PdCode { get; set; }
    }
}
