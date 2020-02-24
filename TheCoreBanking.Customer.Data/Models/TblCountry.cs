using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCountry
    {
        public TblCountry()
        {
            TblCompany = new HashSet<TblCompany>();
            TblCustomer = new HashSet<TblCustomer>();
            TblCustomeraddress = new HashSet<TblCustomeraddress>();
            TblInsertcustomerprofile = new HashSet<TblInsertcustomerprofile>();
            TblRegion = new HashSet<TblRegion>();
            TblState = new HashSet<TblState>();
        }

        public int Countryid { get; set; }
        public string Name { get; set; }
        public string Countrycode { get; set; }

        public ICollection<TblCompany> TblCompany { get; set; }
        public ICollection<TblCustomer> TblCustomer { get; set; }
        public ICollection<TblCustomeraddress> TblCustomeraddress { get; set; }
        public ICollection<TblInsertcustomerprofile> TblInsertcustomerprofile { get; set; }
        public ICollection<TblRegion> TblRegion { get; set; }
        public ICollection<TblState> TblState { get; set; }
    }
}
