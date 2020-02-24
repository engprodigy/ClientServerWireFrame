using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblSubsector
    {
        public short Subsectorid { get; set; }
        public short? Sectorid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
