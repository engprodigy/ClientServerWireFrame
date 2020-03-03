using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{

    public partial class TblAccountclosure
    {
        public int Id { get; set; }
        public string Accountnumber { get; set; }
        public decimal Interestamount { get; set; }
        public decimal Smsamount { get; set; }
        public decimal Cotamount { get; set; }
        public decimal Charges { get; set; }
        public decimal? Amountpayable { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public bool Approved { get; set; }
        public bool Disapproved { get; set; }
        public string Approvedby { get; set; }
        public DateTime? Dateapproved { get; set; }
        public string Creditaccount { get; set; }
        public int Operationid { get; set; }
        public string Comment { get; set; }
        public string Reference { get; set; }
        public string Branchcode { get; set; }
        public string Companycode { get; set; }
        public string Remark { get; set; }
    }
}
