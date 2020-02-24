using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCustomeremailcontact
    {
        public int Emailcontactid { get; set; }
        public string Email { get; set; }
        public int Customerid { get; set; }
        public bool Active { get; set; }

        public TblCustomer Customer { get; set; }
    }
}
