using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCustomeridentimodetype
    {
        public TblCustomeridentimodetype()
        {
            TblCustomeridentification = new HashSet<TblCustomeridentification>();
        }

        public int Identificationmodeid { get; set; }
        public string Identificationmode { get; set; }

        public ICollection<TblCustomeridentification> TblCustomeridentification { get; set; }
    }
}
