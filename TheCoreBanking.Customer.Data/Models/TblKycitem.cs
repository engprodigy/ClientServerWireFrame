using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblKycitem
    {
        public TblKycitem()
        {
            TblCustomeraccountkycitem = new HashSet<TblCustomeraccountkycitem>();
        }

        public int Kycitemid { get; set; }
        public int Accounttypeid { get; set; }
        public int Displayorder { get; set; }
        public string Item { get; set; }
        public bool Ismandatory { get; set; }
        public int? Createdby { get; set; }
        public int? Lastupdatedby { get; set; }
        public DateTime? Datetimecreated { get; set; }
        public DateTime? Datetimeupdated { get; set; }
        public bool Isdeleted { get; set; }

        public TblCustomeraccounttype Accounttype { get; set; }
        public ICollection<TblCustomeraccountkycitem> TblCustomeraccountkycitem { get; set; }
    }
}
