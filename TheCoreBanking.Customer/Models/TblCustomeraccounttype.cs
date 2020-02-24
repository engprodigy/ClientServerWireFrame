using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCustomeraccounttype
    {
        public TblCustomeraccounttype()
        {
            TblCustomer = new HashSet<TblCustomer>();
            TblKycitem = new HashSet<TblKycitem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Isdeleted { get; set; }

        public ICollection<TblCustomer> TblCustomer { get; set; }
        public ICollection<TblKycitem> TblKycitem { get; set; }
    }
}
