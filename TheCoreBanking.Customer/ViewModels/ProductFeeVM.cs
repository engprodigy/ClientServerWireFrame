using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheCoreBanking.Customer.ViewModels
{
    public class ProductFeeVM
    {
        public int PdFeesId { get; set; }
        public string PdFeesName { get; set; }
        public string PdFeesInterval { get; set; }
        public int? PdTypeId { get; set; }
    }
}
