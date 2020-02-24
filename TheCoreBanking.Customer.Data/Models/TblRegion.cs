using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblRegion
    {
        public TblRegion()
        {
            TblCustomer = new HashSet<TblCustomer>();
            TblInsertcustomerprofile = new HashSet<TblInsertcustomerprofile>();
            TblState = new HashSet<TblState>();
        }

        public int Regionid { get; set; }
        public int Countryid { get; set; }
        public string Regionname { get; set; }

        public TblCountry Country { get; set; }
        public ICollection<TblCustomer> TblCustomer { get; set; }
        public ICollection<TblInsertcustomerprofile> TblInsertcustomerprofile { get; set; }
        public ICollection<TblState> TblState { get; set; }
    }
}
