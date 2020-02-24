using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingTillfunction
    {
        public int Id { get; set; }
        public string TillFunction { get; set; }
        public int? FunctionId { get; set; }
    }
}
