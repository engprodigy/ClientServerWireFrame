using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCustomeraddress
    {
        public int Addressid { get; set; }
        public int Customerid { get; set; }
        public int Stateid { get; set; }
        public string City { get; set; }
        public int Countryid { get; set; }
        public short Addresstypeid { get; set; }
        public string Address { get; set; }
        public string Hometown { get; set; }
        public string Pobox { get; set; }
        public string Nearestlandmark { get; set; }
        public string Electricmeternumber { get; set; }
        public bool? Active { get; set; }

        public TblCustomeraddresstype Addresstype { get; set; }
        public TblCountry Country { get; set; }
        public TblCustomer Customer { get; set; }
        public TblState State { get; set; }
    }
}
