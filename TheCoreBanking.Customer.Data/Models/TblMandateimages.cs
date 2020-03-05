using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblMandateimages
    {
        public int Fileid { get; set; }
        public int Mandateid { get; set; }
        public string Description { get; set; }
        public string Mime { get; set; }
        public byte[] Byte { get; set; }
        public bool Isdeleted { get; set; }
        public bool? Isapproved { get; set; }
        public bool? Isdisapproved { get; set; }
        public string Approvalstatus { get; set; }
    }
}
