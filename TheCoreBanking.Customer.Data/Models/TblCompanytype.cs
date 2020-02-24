using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCompanytype
    {
        public TblCompanytype()
        {
            TblCompany = new HashSet<TblCompany>();
        }

        public short Companytypeid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<TblCompany> TblCompany { get; set; }
    }
}
