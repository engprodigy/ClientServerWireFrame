using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class ApiClaims
    {
        public int Id { get; set; }
        public int ApiResourceId { get; set; }
        public string Type { get; set; }

        public ApiResources ApiResource { get; set; }
    }
}
