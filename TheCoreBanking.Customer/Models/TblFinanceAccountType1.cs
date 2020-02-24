using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblFinanceAccountType1
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public int? AccountCategoryId { get; set; }
        public int? BalanceSheetOrder { get; set; }
        public int? IncomeSheetOrder { get; set; }
        public bool? Active { get; set; }
        public int? SubCaptionId { get; set; }
        public string MainCaptionCode { get; set; }
    }
}
