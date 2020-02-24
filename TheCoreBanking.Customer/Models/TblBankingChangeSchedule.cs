using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingChangeSchedule
    {
        public int Id { get; set; }
        public string ProdNo { get; set; }
        public string CustCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CoyCode { get; set; }
        public string BrCode { get; set; }
        public int? OpId { get; set; }
        public string Remark { get; set; }
        public string OldSchedule { get; set; }
        public string NewSchedule { get; set; }
        public int? ScheduleMethod { get; set; }
        public bool? Approved { get; set; }
        public bool? Disapproved { get; set; }
        public DateTime? DateApproved { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovalRemark { get; set; }
        public decimal? Frequency { get; set; }
        public string FreqType { get; set; }
        public decimal? PrincipalFrequency { get; set; }
        public string PrincipalFreqType { get; set; }
        public int? Moratorium { get; set; }
        public decimal? Fee { get; set; }
        public int? FeeFreq { get; set; }
        public decimal? OutPrincipal { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public decimal? FixedPrincipal { get; set; }
        public bool? Scheduled { get; set; }
    }
}
