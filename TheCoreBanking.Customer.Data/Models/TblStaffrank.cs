using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblStaffrank
    {
        public TblStaffrank()
        {
            TblStaff = new HashSet<TblStaff>();
        }

        public int Rankid { get; set; }
        public string Rankcode { get; set; }
        public string Rankname { get; set; }
        public int Companyid { get; set; }

        public ICollection<TblStaff> TblStaff { get; set; }
    }
}
