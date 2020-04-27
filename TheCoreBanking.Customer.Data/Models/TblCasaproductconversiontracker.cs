using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCasaproductconversiontracker
    {
        public int Casaprodconvid { get; set; }
        public int Casaaccountid { get; set; }
        public bool? Isdeleted { get; set; }
        public bool? Isapproved { get; set; }
        public bool? Isdisapproved { get; set; }
        public string Approvalstatus { get; set; }
        public int? Copyfileid { get; set; }
        public bool? Isnewlycreated { get; set; }
        public bool? Deleteflag { get; set; }
        public int? Newproductid { get; set; }
        public int? Oldproductid { get; set; }

        //public TblCasa Casaaccount { get; set; }
    }
}
