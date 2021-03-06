﻿using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingReviseRate
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int? Tenor { get; set; }
        public int? Moratorium { get; set; }
        public decimal? Principal { get; set; }
        public int? Instalment { get; set; }
        public decimal? OldRate { get; set; }
        public decimal? NewRate { get; set; }
        public string ProductName { get; set; }
        public string CustCode { get; set; }
        public string ProdCode { get; set; }
        public string CoyCode { get; set; }
        public bool? ApprovedAdvance { get; set; }
        public bool? ApprovedLease { get; set; }
        public bool? ApprovedLoan { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string LastPrincipalpaid { get; set; }
        public int? InstalmentLeft { get; set; }
        public string LastInterestPaid { get; set; }
        public string ProductAccNo { get; set; }
        public string Remark { get; set; }
        public string BranchId { get; set; }
        public int? Operationid { get; set; }
        public bool? DisapprovedAdvance { get; set; }
        public bool? DisapprovedLease { get; set; }
        public bool? DisapprovedLoan { get; set; }
        public string ProductType { get; set; }
        public string MisCode { get; set; }
        public string Comment { get; set; }
    }
}
