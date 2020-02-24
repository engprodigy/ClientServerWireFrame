using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblFreezetransactionlist
    {
        public TblFreezetransactionlist()
        {
            TblAccountfreeze = new HashSet<TblAccountfreeze>();
        }

        public int Id { get; set; }
        public string FreezeTransaction { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public ICollection<TblAccountfreeze> TblAccountfreeze { get; set; }
    }
}
