using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCity
    {
        public TblCity()
        {
            TblBranch = new HashSet<TblBranch>();
            TblStaff = new HashSet<TblStaff>();
        }

        public int Cityid { get; set; }
        public string Cityname { get; set; }
        public int Stateid { get; set; }
        public short Cityclassid { get; set; }
        public bool Allowedforcollateral { get; set; }

        public ICollection<TblBranch> TblBranch { get; set; }
        public ICollection<TblStaff> TblStaff { get; set; }
    }
}
