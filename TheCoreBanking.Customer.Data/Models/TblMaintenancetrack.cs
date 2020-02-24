using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblMaintenancetrack
    {
        public int Id { get; set; }
        public string CustCode { get; set; }
        public string ProductAcctNo { get; set; }
        public int? Operation { get; set; }
        public bool? Approved { get; set; }
        public bool? Disapproved { get; set; }
        public string Coy { get; set; }
        public string BranchId { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? OpCode { get; set; }
        public string Reference { get; set; }
        public string CreatedBy { get; set; }
        public string Remark { get; set; }
    }
}
