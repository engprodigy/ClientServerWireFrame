using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblBusinesscategory
    {
        public TblBusinesscategory()
        {
            TblCustomer = new HashSet<TblCustomer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblCustomer> TblCustomer { get; set; }
    }
}
