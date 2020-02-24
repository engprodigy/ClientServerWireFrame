using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCustomeraccountkycitem
    {
        public int Customeraccountkycitemid { get; set; }
        public int Kycitemid { get; set; }
        public int Customerid { get; set; }
        public int? Actionid { get; set; }
        public DateTime? Actiondate { get; set; }
        public bool? Disapproved { get; set; }
        public bool? Approved { get; set; }
        public bool? Dateapproved { get; set; }
        public bool? Approvedby { get; set; }
        public string Createdby { get; set; }
        public int? Lastupdatedby { get; set; }
        public DateTime? Datetimecreated { get; set; }
        public DateTime? Datetimeupdated { get; set; }

        public TblKycitemaction Action { get; set; }
        public TblCustomer Customer { get; set; }
        public TblKycitem Kycitem { get; set; }
    }
}
