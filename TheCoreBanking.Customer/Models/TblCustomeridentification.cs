using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCustomeridentification
    {
        public int Identificationid { get; set; }
        public int Customerid { get; set; }
        public string Identificationno { get; set; }
        public int? Identificationmodeid { get; set; }
        public string Issueplace { get; set; }
        public string Issueauthority { get; set; }

        public TblCustomer Customer { get; set; }
        public TblCustomeridentimodetype Identificationmode { get; set; }
    }
}
