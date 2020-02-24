using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingProductAccountCriteria
    {
        public int Id { get; set; }
        public int PdId { get; set; }
        public bool Branch { get; set; }
        public bool CustomerCode { get; set; }
        public bool CompanyCode { get; set; }
        public bool ProductCode { get; set; }
        public bool ProductClassCode { get; set; }
    }
}
