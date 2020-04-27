using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCustomeraccountalertmedium
    {
        public int Id { get; set; }
        public int Alertmediumid { get; set; }
        public int Customeraccountserviceid { get; set; }
        public bool? Isdeleted { get; set; }
        public bool? Isapproved { get; set; }
        public bool? Isdisapproved { get; set; }
        public string Approvalstatus { get; set; }
        public int? Copyfileid { get; set; }

        public TblAccountalertmedium Alertmedium { get; set; }
        public TblCustomeraccountservice Customeraccountservice { get; set; }
    }
}
