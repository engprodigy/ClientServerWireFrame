using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCustomeraccountbankingservice
    {
        public int Id { get; set; }
        public int Bankingserviceid { get; set; }
        public int Customeraccountserviceid { get; set; }

        public TblAccountbankingservice Bankingservice { get; set; }
        public TblCustomeraccountservice Customeraccountservice { get; set; }
    }
}
