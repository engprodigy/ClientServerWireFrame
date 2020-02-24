using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblMaritalstatus
    {
        public TblMaritalstatus()
        {
            TblCustomer = new HashSet<TblCustomer>();
            TblEditedcustomer = new HashSet<TblEditedcustomer>();
            TblInsertcustomerprofile = new HashSet<TblInsertcustomerprofile>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime? Datecreated { get; set; }
        public bool Isdeleted { get; set; }

        public ICollection<TblCustomer> TblCustomer { get; set; }
        public ICollection<TblEditedcustomer> TblEditedcustomer { get; set; }
        public ICollection<TblInsertcustomerprofile> TblInsertcustomerprofile { get; set; }
    }
}
