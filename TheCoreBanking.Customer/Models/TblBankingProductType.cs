using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBankingProductType
    {
        public TblBankingProductType()
        {
            TblProduct = new HashSet<TblProduct>();
        }

        public int PdTypeId { get; set; }
        public string PdType { get; set; }
        public int PdGroupId { get; set; }
        public int PdPayDay { get; set; }

        public ICollection<TblProduct> TblProduct { get; set; }
    }
}
