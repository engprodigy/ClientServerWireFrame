using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblStampcharge
    {
        public int Id { get; set; }
        public decimal Charge { get; set; }
        public DateTime Datecreated { get; set; }
        public long? Chartofaccountid { get; set; }

        public TblFinanceChartOfAccount Chartofaccount { get; set; }
    }
}
