﻿using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblChequeleafstatus
    {
        public TblChequeleafstatus()
        {
            TblChequeleavesdetail = new HashSet<TblChequeleavesdetail>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public ICollection<TblChequeleavesdetail> TblChequeleavesdetail { get; set; }
    }
}
