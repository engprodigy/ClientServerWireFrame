using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblAccountreferee
    {
        public int Refereeid { get; set; }
        public int Casaaccountid { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Accountname { get; set; }
        public string Accountno { get; set; }
        public string Relationship { get; set; }
        public int? Bankid { get; set; }
        public string Bankaddress { get; set; }
        public DateTime Datecreated { get; set; }
        public bool Isdeleted { get; set; }

        public TblCasa Casaaccount { get; set; }
    }
}
