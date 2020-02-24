using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblAccountbankingservice
    {
        public TblAccountbankingservice()
        {
            TblCustomeraccountbankingservice = new HashSet<TblCustomeraccountbankingservice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }

        public ICollection<TblCustomeraccountbankingservice> TblCustomeraccountbankingservice { get; set; }
    }
}
