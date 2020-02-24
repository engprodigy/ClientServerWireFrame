using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingProductFees
    {
        public int PdFeesId { get; set; }
        public int? Catid { get; set; }
        public string PdFeesName { get; set; }
        public int? PdFixed { get; set; }
        public bool? PdRate { get; set; }
        public int? PdTarget { get; set; }
        public string PdFeesLedgerDr { get; set; }
        public string PdFeesLedgerCr { get; set; }
        public string PdFeesInterval { get; set; }
        public DateTime PdFeedate { get; set; }
        public int? SubcatId { get; set; }
        public int? PdTypeId { get; set; }
        public string Subcat { get; set; }
        public bool? IncludeCutOffDate { get; set; }
        public int? CutOfDay { get; set; }
        public decimal? FeeValue { get; set; }
    }
}
