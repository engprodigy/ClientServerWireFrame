using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblProcesstype
    {
        public TblProcesstype()
        {
            TblInsertcustomerprofile = new HashSet<TblInsertcustomerprofile>();
        }

        public int Id { get; set; }
        public string Processtype { get; set; }

        public ICollection<TblInsertcustomerprofile> TblInsertcustomerprofile { get; set; }
    }
}
