using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblStaffjobtitle
    {
        public TblStaffjobtitle()
        {
            TblStaff = new HashSet<TblStaff>();
        }

        public int Jobtitleid { get; set; }
        public string Jobtitlename { get; set; }
        public int Companyid { get; set; }

        public ICollection<TblStaff> TblStaff { get; set; }
    }
}
