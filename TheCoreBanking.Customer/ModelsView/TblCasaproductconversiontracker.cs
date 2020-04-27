using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.ModelsView
{
    public partial class TblCasaproductconversiontracker
    {
        public int Id { get; set; }
        public int Casaaccountid { get; set; }
        public bool? Isdeleted { get; set; }
        public bool? Isapproved { get; set; }
        public bool? Isdisapproved { get; set; }
        public string Approvalstatus { get; set; }
        public int? Copyfileid { get; set; }
        public bool? Isnewlycreated { get; set; }
        public bool? Deleteflag { get; set; }

        public TblCasa Casaaccount { get; set; }
    }
}
