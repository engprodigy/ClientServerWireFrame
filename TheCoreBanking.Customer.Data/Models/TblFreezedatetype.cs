using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblFreezedatetype
    {
        public TblFreezedatetype()
        {
            TblAccountfreeze = new HashSet<TblAccountfreeze>();
        }

        public int Id { get; set; }
        public string DateType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<TblAccountfreeze> TblAccountfreeze { get; set; }
    }
}
