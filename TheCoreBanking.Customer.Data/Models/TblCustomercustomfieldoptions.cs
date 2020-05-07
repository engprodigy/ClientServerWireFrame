using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblCustomercustomfieldoptions
    {
        public int Id { get; set; }
        public int CustomerCustomFieldListId { get; set; }
        public string OptionName { get; set; }
    }
}
