using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCustomerblacklist
    {
        public int CustomerBlacklistid { get; set; }
        public int? Companyid { get; set; }
        public int? Customerid { get; set; }
        public DateTime? Dateblacklisted { get; set; }
        public string Reason { get; set; }
        public bool? Iscurrent { get; set; }

        public TblCompany Company { get; set; }
        public TblCustomer Customer { get; set; }
    }
}
