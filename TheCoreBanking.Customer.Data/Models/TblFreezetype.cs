using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblFreezetype
    {
        public TblFreezetype()
        {
            TblAccountfreeze = new HashSet<TblAccountfreeze>();
        }

        public int Id { get; set; }
        public string FreezeType { get; set; }
        public bool? Active { get; set; }

        public ICollection<TblAccountfreeze> TblAccountfreeze { get; set; }
    }
}
