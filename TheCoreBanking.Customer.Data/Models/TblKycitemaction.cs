using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblKycitemaction
    {
        public TblKycitemaction()
        {
            TblCustomeraccountkycitem = new HashSet<TblCustomeraccountkycitem>();
        }

        public int Id { get; set; }
        public string Action { get; set; }

        public ICollection<TblCustomeraccountkycitem> TblCustomeraccountkycitem { get; set; }
    }
}
