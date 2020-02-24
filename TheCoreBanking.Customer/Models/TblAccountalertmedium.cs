using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblAccountalertmedium
    {
        public TblAccountalertmedium()
        {
            TblCustomeraccountalertmedium = new HashSet<TblCustomeraccountalertmedium>();
        }

        public int Id { get; set; }
        public string Alerttype { get; set; }
        public bool? Active { get; set; }

        public ICollection<TblCustomeraccountalertmedium> TblCustomeraccountalertmedium { get; set; }
    }
}
