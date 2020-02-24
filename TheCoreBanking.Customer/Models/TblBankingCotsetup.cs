using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingCotsetup
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public int? PdId { get; set; }
        public bool? Withdrawal { get; set; }
        public bool? Deposit { get; set; }
        public bool? Lodgement { get; set; }
        public bool? TransferSameAccount { get; set; }
        public bool? TransferDiffAccount { get; set; }
        public bool? InterBankTransferSameAccount { get; set; }
        public bool? InterBankTransferDifferentAccount { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public string BrCode { get; set; }
        public string CoyCode { get; set; }
        public string FeeName { get; set; }
        public bool? IsFeeRate { get; set; }
        public decimal? FeeAmt { get; set; }
        public decimal? MinTransAmt { get; set; }
        public string DebitGl { get; set; }
        public string CreditGl { get; set; }
        public int? CutoffDay { get; set; }
        public string Remark { get; set; }
        public bool? Active { get; set; }
    }
}
