using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblTitle
    {
        public TblTitle()
        {
            TblCustomer = new HashSet<TblCustomer>();
            TblEditedcustomer = new HashSet<TblEditedcustomer>();
            TblInsertcustomerprofile = new HashSet<TblInsertcustomerprofile>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public bool Isdeleted { get; set; }

        public ICollection<TblCustomer> TblCustomer { get; set; }
        public ICollection<TblEditedcustomer> TblEditedcustomer { get; set; }
        public ICollection<TblInsertcustomerprofile> TblInsertcustomerprofile { get; set; }
    }
}
