using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblRefereedocuments
    {
        public int Id { get; set; }
        public int Refereeid { get; set; }
        public string Mime { get; set; }
        public byte[] Filedata { get; set; }
        public bool Isdeleted { get; set; }
    }
}
