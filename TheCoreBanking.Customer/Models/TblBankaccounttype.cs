using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankaccounttype
    {
        public TblBankaccounttype()
        {
            TblCustomer = new HashSet<TblCustomer>();
            TblInsertcustomerprofile = new HashSet<TblInsertcustomerprofile>();
        }

        public int Id { get; set; }
        public string Accounttype { get; set; }

        public ICollection<TblCustomer> TblCustomer { get; set; }
        public ICollection<TblInsertcustomerprofile> TblInsertcustomerprofile { get; set; }
    }
}
