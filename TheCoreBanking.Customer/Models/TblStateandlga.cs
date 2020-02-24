using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblStateandlga
    {
        public TblStateandlga()
        {
            TblBranch = new HashSet<TblBranch>();
            TblCustomer = new HashSet<TblCustomer>();
            TblInsertcustomerprofile = new HashSet<TblInsertcustomerprofile>();
            TblState = new HashSet<TblState>();
        }

        public int Id { get; set; }
        public string State { get; set; }
        public string Lga { get; set; }
        public int? Stateid { get; set; }

        public ICollection<TblBranch> TblBranch { get; set; }
        public ICollection<TblCustomer> TblCustomer { get; set; }
        public ICollection<TblInsertcustomerprofile> TblInsertcustomerprofile { get; set; }
        public ICollection<TblState> TblState { get; set; }
    }
}
