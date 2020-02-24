using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingCommittee
    {
        public int Id { get; set; }
        public bool? Committee { get; set; }
        public int? BoardNo { get; set; }
        public int? MgtNo { get; set; }
        public decimal? CreditMinMgt { get; set; }
        public string CoyCode { get; set; }
        public string BrCode { get; set; }
        public string Createdby { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? CreditMinBoard { get; set; }
        public int? MgtNoApproval { get; set; }
        public int? BoardNoApproval { get; set; }
        public int? OperationId { get; set; }
        public string CommitteeType { get; set; }
        public decimal? CreditMaxComteeAmt { get; set; }
        public decimal? CreditMaxBoardAmt { get; set; }
    }
}
