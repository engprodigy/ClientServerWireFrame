using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCustomerphonecontact
    {
        public int Phonecontactid { get; set; }
        public string Phone { get; set; }
        public int Customerid { get; set; }
        public bool Active { get; set; }

        public TblCustomer Customer { get; set; }
    }
}
