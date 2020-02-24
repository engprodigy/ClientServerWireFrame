using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingCustomerSecurity
    {
        public int Id { get; set; }
        public string CustCode { get; set; }
        public string ProductId { get; set; }
        public string ProductAcctNo { get; set; }
        public int? SecurityId { get; set; }
        public string SecuritySchedule { get; set; }
        public int? MyCount { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CoyCode { get; set; }
        public string BranchId { get; set; }
        public string Miscode { get; set; }
        public bool? SelectedSec { get; set; }
        public decimal? SecValue { get; set; }
        public string ShareCoy { get; set; }
        public int? ShareQty { get; set; }
        public decimal? ShareMktPrice { get; set; }
        public string DealId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? MaturityDate { get; set; }
        public decimal? MaturityAmt { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string Counterparty { get; set; }
        public string PolicyRef { get; set; }
        public string InsuranceCoverage { get; set; }
        public string InsuranceCoy { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string LienAccountNo { get; set; }
        public string SecType { get; set; }
        public string RcustCode { get; set; }
        public decimal? SecurityValue { get; set; }
        public decimal? Fsv { get; set; }
        public string LegalPerfection { get; set; }
        public string Insurance { get; set; }
        public string Tracking { get; set; }
        public string DocInCustody { get; set; }
        public string AssetDescr { get; set; }
        public string Valuer { get; set; }
        public DateTime? ValuationDate { get; set; }
        public decimal? Omv { get; set; }
        public DateTime? InsurEffectiveDate { get; set; }
        public string MyPath { get; set; }
        public decimal? ForcedSaleValue { get; set; }
        public decimal? OpenMarketValue { get; set; }
        public string NameOfStockOwner { get; set; }
        public string InvestmentOwner { get; set; }
        public string NameOfCompany { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public string Relationship { get; set; }
        public string DurationOfRelationship { get; set; }
        public string CompanyAddress { get; set; }
        public string BusinessAddress { get; set; }
        public int? DealFrom { get; set; }
        public decimal? HairCut { get; set; }
        public decimal? DealAmount { get; set; }
        public string GuarantorName { get; set; }
    }
}
