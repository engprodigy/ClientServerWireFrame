using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblMmarketUnfrozenCallAccount
    {
        public int Id { get; set; }
        public string CpId { get; set; }
        public string DealId { get; set; }
        public string CurrentAcct { get; set; }
        public decimal? FaceValue { get; set; }
        public decimal? AmountUnFrozen { get; set; }
        public string AmountUnFrozenBy { get; set; }
        public DateTime? DateUnFrozen { get; set; }
        public string UnFreezingType { get; set; }
        public bool? UnFrozen { get; set; }
        public int? OperationId { get; set; }
        public bool? Approved { get; set; }
        public bool? Disapproved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public string Comment { get; set; }
        public string ApprovingRemark { get; set; }
        public string CoyCode { get; set; }
        public string BrCode { get; set; }
        public string UnFreezingTypeId { get; set; }
    }
}
