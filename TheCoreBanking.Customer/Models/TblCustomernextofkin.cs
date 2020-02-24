using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCustomernextofkin
    {
        public int Nextofkinid { get; set; }
        public string Nextofkinname { get; set; }
        public string Nextofkinfirstname { get; set; }
        public string Nextofkinphonenumber { get; set; }
        public string Nestofkinemail { get; set; }
        public string Nestofkinaddress { get; set; }
        public int Customerid { get; set; }
        public bool? Active { get; set; }

        public TblCustomer Customer { get; set; }
    }
}
