using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblGender
    {
        public TblGender()
        {
            TblCustomerGender = new HashSet<TblCustomer>();
            TblCustomerNokgender = new HashSet<TblCustomer>();
            TblEditedcustomer = new HashSet<TblEditedcustomer>();
            TblInsertcustomerprofile = new HashSet<TblInsertcustomerprofile>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblCustomer> TblCustomerGender { get; set; }
        public ICollection<TblCustomer> TblCustomerNokgender { get; set; }
        public ICollection<TblEditedcustomer> TblEditedcustomer { get; set; }
        public ICollection<TblInsertcustomerprofile> TblInsertcustomerprofile { get; set; }
    }
}
