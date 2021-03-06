﻿using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCompanyclass
    {
        public TblCompanyclass()
        {
            TblCompany = new HashSet<TblCompany>();
        }

        public short Companyclassid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<TblCompany> TblCompany { get; set; }
    }
}
