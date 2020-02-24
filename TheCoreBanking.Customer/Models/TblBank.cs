using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBank
    {
        public TblBank()
        {
            TblCustomer = new HashSet<TblCustomer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }

        public ICollection<TblCustomer> TblCustomer { get; set; }
    }
}
