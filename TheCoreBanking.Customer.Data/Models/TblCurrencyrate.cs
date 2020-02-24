using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCurrencyrate
    {
        public short Currencyrateid { get; set; }
        public short Currencyid { get; set; }
        public DateTime Date { get; set; }
        public double Buyingrate { get; set; }
        public double Sellingrate { get; set; }
        public short Basecurrencyid { get; set; }
        public int Createdby { get; set; }
        public DateTime Datetimecreated { get; set; }
        public int? Lastupdatedby { get; set; }
        public DateTime? Datetimeupdated { get; set; }
        public bool Deleted { get; set; }
    }
}
