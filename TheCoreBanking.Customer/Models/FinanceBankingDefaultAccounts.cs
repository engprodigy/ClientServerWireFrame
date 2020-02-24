using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class FinanceBankingDefaultAccounts
    {
        public long Id { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
    }
}
