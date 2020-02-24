using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblApprovalstatus
    {
        public TblApprovalstatus()
        {
            TblOutwardbankcheque = new HashSet<TblOutwardbankcheque>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public ICollection<TblOutwardbankcheque> TblOutwardbankcheque { get; set; }
    }
}
