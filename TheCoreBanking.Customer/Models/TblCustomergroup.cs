using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCustomergroup
    {
        public int Groupid { get; set; }
        public string Groupname { get; set; }
        public bool Isactive { get; set; }
        public int? Companyid { get; set; }
        public string Branch { get; set; }
        public DateTime? Lastupdated { get; set; }
        public bool Iscommittee { get; set; }
    }
}
