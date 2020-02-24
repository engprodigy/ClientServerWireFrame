using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCustomeraccountstmntmedium
    {
        public int Id { get; set; }
        public int Statementmediumid { get; set; }
        public int Customeraccountserviceid { get; set; }

        public TblCustomeraccountservice Customeraccountservice { get; set; }
        public TblAccountstmntmedium Statementmedium { get; set; }
    }
}
