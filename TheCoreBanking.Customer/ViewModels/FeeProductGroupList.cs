using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheCoreBanking.Customer.ViewModels
{
    public class FeeProductGroupList
    {
       public int ID { get; set; }
       public string productId { get; set; }
       public string productName { get; set; }
       public string feeName { get; set; }
       public int feeId { get; set; }
       public string approvalstatus { get; set; }
}
}
