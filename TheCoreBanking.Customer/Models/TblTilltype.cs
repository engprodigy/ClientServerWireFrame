using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblTilltype
    {
        public TblTilltype()
        {
            TblTillmapping = new HashSet<TblTillmapping>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<TblTillmapping> TblTillmapping { get; set; }
    }
}
