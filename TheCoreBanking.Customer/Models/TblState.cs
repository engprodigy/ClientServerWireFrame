using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblState
    {
        public TblState()
        {
            TblBranch = new HashSet<TblBranch>();
            TblCustomerStateoforigin = new HashSet<TblCustomer>();
            TblCustomerWorkstateNavigation = new HashSet<TblCustomer>();
            TblCustomeraddress = new HashSet<TblCustomeraddress>();
            TblInsertcustomerprofile = new HashSet<TblInsertcustomerprofile>();
        }

        public int Stateid { get; set; }
        public string Statename { get; set; }
        public int? Lgaid { get; set; }
        public int? Countryid { get; set; }
        public int? Regionid { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datetimecreated { get; set; }

        public TblCountry Country { get; set; }
        public TblStateandlga Lga { get; set; }
        public TblRegion Region { get; set; }
        public ICollection<TblBranch> TblBranch { get; set; }
        public ICollection<TblCustomer> TblCustomerStateoforigin { get; set; }
        public ICollection<TblCustomer> TblCustomerWorkstateNavigation { get; set; }
        public ICollection<TblCustomeraddress> TblCustomeraddress { get; set; }
        public ICollection<TblInsertcustomerprofile> TblInsertcustomerprofile { get; set; }
    }
}
