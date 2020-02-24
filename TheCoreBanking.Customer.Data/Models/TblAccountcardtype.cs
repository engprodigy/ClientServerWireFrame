using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblAccountcardtype
    {
        public TblAccountcardtype()
        {
            TblCustomeraccountservice = new HashSet<TblCustomeraccountservice>();
        }

        public int Id { get; set; }
        public string Cardname { get; set; }
        public bool? Active { get; set; }

        public ICollection<TblCustomeraccountservice> TblCustomeraccountservice { get; set; }
    }
}
