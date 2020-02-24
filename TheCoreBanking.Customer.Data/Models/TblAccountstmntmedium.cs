using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblAccountstmntmedium
    {
        public TblAccountstmntmedium()
        {
            TblCustomeraccountstmntmedium = new HashSet<TblCustomeraccountstmntmedium>();
        }

        public int Id { get; set; }
        public string Statementmedium { get; set; }
        public bool? Active { get; set; }

        public ICollection<TblCustomeraccountstmntmedium> TblCustomeraccountstmntmedium { get; set; }
    }
}
