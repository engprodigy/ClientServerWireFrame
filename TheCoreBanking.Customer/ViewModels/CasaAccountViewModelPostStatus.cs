using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheCoreBanking.Customer.ViewModels
{
    public class CasaAccountViewModelPostStatus
    {

        public int Casaaccountid { get; set; }
        public string Accountnumber { get; set; }
        public string Accountname { get; set; }
        public int Customerid { get; set; }
        public int Productid { get; set; }
        public string ProductName { get; set; }
        public int Postnostatusid { get; set; }
        public int? Approvalstatusid { get; set; }
    }
}
