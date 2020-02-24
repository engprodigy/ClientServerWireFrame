using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCasafreeze
    {
        public int Id { get; set; }
        public string Customercode { get; set; }
        public string Productaccountno { get; set; }
        public string Accountname { get; set; }
        public int? Branchid { get; set; }
        public int? Companyid { get; set; }
        public string Miscode { get; set; }
        public DateTime? Datecreated { get; set; }
        public int? Attacheddocumentid { get; set; }
        public string Remark { get; set; }
        public bool? Approved { get; set; }
        public string Approvedby { get; set; }
        public DateTime? Dateapproved { get; set; }
        public int? Operationid { get; set; }
        public decimal? Balance { get; set; }
        public bool? Disapproved { get; set; }
        public bool? Sourceca { get; set; }
        public bool? Destinationca { get; set; }
        public string Transactiontime { get; set; }
        public string Tillaccount { get; set; }
        public string Principalbalancegl { get; set; }
        public string Customerbranch { get; set; }
        public string Narration { get; set; }
        public decimal? Freezeamount { get; set; }
        public bool? Isreversed { get; set; }
        public string Username { get; set; }
    }
}
