using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCustomerbvn
    {
        public int Customerbvnid { get; set; }
        public int Customerid { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Bankverificationnumber { get; set; }
        public bool Isvalidbvn { get; set; }
        public bool Ispoliticallyexposed { get; set; }
        public int Createdby { get; set; }
        public int? Lastupdatedby { get; set; }
        public DateTime Datetimecreated { get; set; }
        public DateTime? Datetimeupdated { get; set; }
    }
}
