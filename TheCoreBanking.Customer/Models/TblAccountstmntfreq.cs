﻿using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblAccountstmntfreq
    {
        public TblAccountstmntfreq()
        {
            TblCustomeraccountservice = new HashSet<TblCustomeraccountservice>();
        }

        public int Id { get; set; }
        public string Frequency { get; set; }
        public bool? Active { get; set; }

        public ICollection<TblCustomeraccountservice> TblCustomeraccountservice { get; set; }
    }
}
