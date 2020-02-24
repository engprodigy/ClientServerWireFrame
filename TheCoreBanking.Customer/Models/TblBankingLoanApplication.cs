using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingLoanApplication
    {
        public int Id { get; set; }
        public string CustName { get; set; }
        public string CustCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductAcctNo { get; set; }
        public string BranchId { get; set; }
        public int? Tenor { get; set; }
        public decimal? Rate { get; set; }
        public int? Moratorium { get; set; }
        public int? Installments { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? TerminalDate { get; set; }
        public string CoyCode { get; set; }
        public string Miscode { get; set; }
        public DateTime? DateCreated { get; set; }
        public decimal? Principal { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public int? Status { get; set; }
        public string CurrentAcct { get; set; }
        public string OpeningComment { get; set; }
        public string ApprovalComment { get; set; }
        public bool? Email { get; set; }
        public bool? Sms { get; set; }
        public bool? InternetBanking { get; set; }
        public int? SchMethod { get; set; }
        public decimal? Frequency { get; set; }
        public string FreqType { get; set; }
        public decimal? TargetAmount { get; set; }
        public string Ref { get; set; }
        public int? TenorMode { get; set; }
        public bool? MoraWinthInterest { get; set; }
        public bool? DisChargeLetter { get; set; }
        public decimal? InterestAmount { get; set; }
        public decimal? MaturityAmount { get; set; }
        public decimal? SchPayment { get; set; }
        public int? CategoryId { get; set; }
        public int? PdTypeId { get; set; }
        public bool? Paid { get; set; }
        public decimal? AmountPaid { get; set; }
        public string Currency { get; set; }
        public DateTime? DatePaid { get; set; }
        public decimal? CurrRate { get; set; }
        public decimal? FeeCharge { get; set; }
        public int? FeeFrequency { get; set; }
        public DateTime? FirstpayDate { get; set; }
        public decimal? OutstandingPrincipal { get; set; }
        public decimal? ApprovedAmount { get; set; }
        public decimal? PrincipalFrequency { get; set; }
        public string PrincipalFreqType { get; set; }
        public decimal? UpfrontInterest { get; set; }
        public decimal? Upfrontprincipal { get; set; }
        public string RelationshipManager { get; set; }
        public string RelationshipManagerDept { get; set; }
        public string RelationshipOfficer { get; set; }
        public string RelationshipOfficerDept { get; set; }
    }
}
