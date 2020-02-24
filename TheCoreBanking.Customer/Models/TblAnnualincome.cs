using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblAnnualincome
    {
        public TblAnnualincome()
        {
            TblCustomer = new HashSet<TblCustomer>();
            TblEditedcustomerAnnualincome = new HashSet<TblEditedcustomer>();
        }

        public int Id { get; set; }
        public string Range { get; set; }
        public string Accounttype { get; set; }

        public TblEditedcustomer TblEditedcustomerCustomer { get; set; }
        public ICollection<TblCustomer> TblCustomer { get; set; }
        public ICollection<TblEditedcustomer> TblEditedcustomerAnnualincome { get; set; }
    }
}
