using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblSourceoffunds
    {
        public TblSourceoffunds()
        {
            TblCustomer = new HashSet<TblCustomer>();
        }

        public int Id { get; set; }
        public string Source { get; set; }
        public bool Deleted { get; set; }

        public ICollection<TblCustomer> TblCustomer { get; set; }
    }
}
