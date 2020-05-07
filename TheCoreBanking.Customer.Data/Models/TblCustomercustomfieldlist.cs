using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCustomercustomfieldlist
    {
        public int Id { get; set; }
        public int InputTypeId { get; set; }
        public string InputName { get; set; }
        public string InputLabel { get; set; }
    }
}
