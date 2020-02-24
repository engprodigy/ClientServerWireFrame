using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCurrency
    {
        public TblCurrency()
        {
            TblCompany = new HashSet<TblCompany>();
        }

        public short Currencyid { get; set; }
        public string Currencycode { get; set; }
        public string Currencyname { get; set; }
        public bool Inuse { get; set; }
        public int? Createdby { get; set; }
        public int? Lastupdatedby { get; set; }
        public DateTime Datetimecreated { get; set; }
        public DateTime? Datetimeupdated { get; set; }

        public ICollection<TblCompany> TblCompany { get; set; }
    }
}
