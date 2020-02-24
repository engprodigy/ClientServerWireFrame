using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingOperationSetup
    {
        public int Id { get; set; }
        public string Operation { get; set; }
        public bool? Active { get; set; }
    }
}
