using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCustomeraddresstype
    {
        public TblCustomeraddresstype()
        {
            TblCustomeraddress = new HashSet<TblCustomeraddress>();
        }

        public short Addresstypeid { get; set; }
        public string AddressTypeName { get; set; }

        public ICollection<TblCustomeraddress> TblCustomeraddress { get; set; }
    }
}
