using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblKycdocuments
    {
        public int Id { get; set; }
        public int Customerid { get; set; }
        public string Title { get; set; }
        public string Mime { get; set; }
        public byte[] Filedata { get; set; }
        public bool Isdeleted { get; set; }
    }
}
