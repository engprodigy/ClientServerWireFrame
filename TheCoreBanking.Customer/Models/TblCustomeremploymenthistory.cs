using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCustomeremploymenthistory
    {
        public int Placeofworkid { get; set; }
        public string Employername { get; set; }
        public string Employeraddress { get; set; }
        public int Employerstateid { get; set; }
        public int Employercountryid { get; set; }
        public string Officephone { get; set; }
        public DateTime Employdate { get; set; }
        public string Previousemployer { get; set; }
        public int? Customerid { get; set; }
        public bool Active { get; set; }
    }
}
