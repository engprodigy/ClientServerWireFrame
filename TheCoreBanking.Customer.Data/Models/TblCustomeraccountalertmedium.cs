using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCustomeraccountalertmedium
    {
        public int Id { get; set; }
        public int Alertmediumid { get; set; }
        public int Customeraccountserviceid { get; set; }

        public TblAccountalertmedium Alertmedium { get; set; }
        public TblCustomeraccountservice Customeraccountservice { get; set; }
    }
}
