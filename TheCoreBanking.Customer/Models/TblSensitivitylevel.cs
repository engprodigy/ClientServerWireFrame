using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblSensitivitylevel
    {
        public TblSensitivitylevel()
        {
            TblCustomer = new HashSet<TblCustomer>();
        }

        public int Id { get; set; }
        public string Sensitivitylevel { get; set; }
        public bool? Active { get; set; }

        public ICollection<TblCustomer> TblCustomer { get; set; }
    }
}
