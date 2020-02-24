using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingProduct
    {
        public int Id { get; set; }
        public int PdId { get; set; }
        public string PdCode { get; set; }
        public string OldpdCode { get; set; }
        public string PdName { get; set; }
        public string PdDescription { get; set; }
        public int PdTypeId { get; set; }
        public int PdCategoryId { get; set; }
        public bool PdMoratorium { get; set; }
        public bool PdApplyWht { get; set; }
        public string PdPrincipalBalanceGl { get; set; }
        public string PdInterestGl { get; set; }
        public string PdInterestRvGl { get; set; }
        public string PdMmtype { get; set; }
        public int PdMaxTenor { get; set; }
        public int PdMinTenor { get; set; }
        public decimal PdMaxRate { get; set; }
        public decimal PdMinRate { get; set; }
        public decimal PdOpeningBalance { get; set; }
        public decimal PdMinimumBalance { get; set; }
        public bool PdCompleted { get; set; }
        public int PdStep { get; set; }
        public string PdMadeby { get; set; }
        public bool PdApproved { get; set; }
        public string ApprovedBy { get; set; }
        public bool? PdOverdraft { get; set; }
        public bool? AllowRate { get; set; }
        public bool? AllowTenor { get; set; }
        public string DealClassification { get; set; }
        public string PdDormantGl { get; set; }
        public string PdBondPremium { get; set; }
        public string PdBondDiscount { get; set; }
        public string PdBondGl { get; set; }
        public string TreasuryBillType { get; set; }
        public string SettlementDate { get; set; }
        public string Act { get; set; }
        public bool? Remit { get; set; }
        public string CoyCode { get; set; }
        public int? ClassificationId { get; set; }
        public string InterestsBs { get; set; }
    }
}
