using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblBankingcasa
    {
        public int Id { get; set; }
        public string CustCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public bool? CurrentAcct { get; set; }
        public string ProductAcctNo { get; set; }
        public string BranchId { get; set; }
        public int? Tenor { get; set; }
        public decimal? Rate { get; set; }
        public int? Moratorium { get; set; }
        public int? Installments { get; set; }
        public DateTime? EffectDate { get; set; }
        public DateTime? TerminalDate { get; set; }
        public string CoyCode { get; set; }
        public string Miscode { get; set; }
        public DateTime? DateCreated { get; set; }
        public decimal? Deposit { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public int? Status { get; set; }
        public int? OperationId { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Interest { get; set; }
        public string AccountName { get; set; }
        public bool? Disapproved { get; set; }
        public string Sbumis { get; set; }
        public string Officer1 { get; set; }
        public string Officer2 { get; set; }
        public int? PdId { get; set; }
        public decimal? Odamount { get; set; }
        public decimal? OdinterestRate { get; set; }
        public DateTime? Odexpiry { get; set; }
        public string Od { get; set; }
        public bool? Sms { get; set; }
        public bool? Email { get; set; }
        public bool? Ib { get; set; }
        public string Currency { get; set; }
        public decimal? CurrRate { get; set; }
        public decimal? LienAmount { get; set; }
        public bool? Lien { get; set; }
        public bool? Pnc { get; set; }
        public bool? Pnd { get; set; }
        public string OldProductAcctNo { get; set; }
        public decimal? CotacctAmt { get; set; }
        public DateTime? Cotdate { get; set; }
        public string CotcreatedBy { get; set; }
        public bool? Tod { get; set; }
        public decimal? Todrate { get; set; }
        public DateTime? Todexpiry { get; set; }
        public decimal? LedgerBalance { get; set; }
        public string Pccode1 { get; set; }
        public string Pccode2 { get; set; }
        public string OldProductAcctNo1 { get; set; }
        public string OldProductAcctNo2 { get; set; }
        public string OldProductAcctNo3 { get; set; }
        public bool? Sent { get; set; }
        public string NubanAccountNumber { get; set; }
        public string OldAccountNuber { get; set; }
        public DateTime? LastCreditDate { get; set; }
        public DateTime? LastDebitDate { get; set; }
    }
}
