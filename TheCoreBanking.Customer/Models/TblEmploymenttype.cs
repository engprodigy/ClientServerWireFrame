using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblEmploymenttype
    {
        public TblEmploymenttype()
        {
            TblCustomer = new HashSet<TblCustomer>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<TblCustomer> TblCustomer { get; set; }
    }
}
