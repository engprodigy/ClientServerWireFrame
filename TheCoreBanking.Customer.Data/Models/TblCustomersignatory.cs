using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCustomersignatory
    {
        public int CustomerSignatoryid { get; set; }
        public int Customerid { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Bvn { get; set; }
        public string Gender { get; set; }
    }
}
