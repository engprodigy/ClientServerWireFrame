using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheCoreBanking.Customer.Data.Models
{
    public class TblAccountfreeze
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public decimal? Balance { get; set; }
        public string FreezeCode { get; set; }
        public int? FreezeTypeId { get; set; }
        public int? DateTypeId { get; set; }
        public int? TransactionToPreventId { get; set; }
        public string FreezeReason { get; set; }
        public string FreezeReason2 { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? AttachedDocumntId { get; set; }
        public bool IsFreeze { get; set; }
        public bool IsTotalFreeze { get; set; }
        public bool IsPartialFreeze { get; set; }
        public bool IsCreditOnlyFreeze { get; set; }
        public bool IsDebitOnlyFreeze { get; set; }
        public bool IsIndefiniteFreeze { get; set; }
        public bool IsApproved { get; set; }
        public bool Disapproved { get; set; }
        public string ApprovedBy { get; set; }
        public string TransactionTime { get; set; }
        public string BranchId { get; set; }
        public bool? IsReversed { get; set; }
        public decimal? FreezeAmount { get; set; }
        public string DocAttachment { get; set; }

        public TblFreezedatetype DateType { get; set; }
        public TblFreezetype FreezeType { get; set; }
        public TblFreezetransactionlist TransactionToPrevent { get; set; }
    }
}
