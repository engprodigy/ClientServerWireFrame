using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheCoreBanking.Customer.ViewModels
{
    public class AddKycItemsVM
    {
        public int Accounttypeid { get; set; }
        public int Displayorder { get; set; }
        public string Item { get; set; }
        public bool Ismandatory { get; set; }
    }
}
