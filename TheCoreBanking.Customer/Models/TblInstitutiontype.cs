using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblInstitutiontype
    {
        public TblInstitutiontype()
        {
            TblCustomer = new HashSet<TblCustomer>();
        }

        public int Id { get; set; }
        public string Typename { get; set; }

        public ICollection<TblCustomer> TblCustomer { get; set; }
    }
}
