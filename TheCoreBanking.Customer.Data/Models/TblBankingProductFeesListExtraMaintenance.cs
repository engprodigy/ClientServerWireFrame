using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblBankingProductFeesListExtraMaintenance
    {
        public int Id { get; set; }
        public int Casaaccountid { get; set; }
        public int? PdId { get; set; }
        public int? PdFeesId { get; set; }
        public decimal? RateValue { get; set; }
        public string PdFeesName { get; set; }
        public bool? PdRate { get; set; }
        public decimal? FeeValue { get; set; }
        public bool? AdditionStatus { get; set; }
        public bool? Isdeleted { get; set; }
        public bool? Isapproved { get; set; }
        public bool? Isdisapproved { get; set; }
        public string Approvalstatus { get; set; }
        public int? Copyfileid { get; set; }
        public bool? Isnewlycreated { get; set; }

        public TblCasa Casaaccount { get; set; }
    }
}
