﻿using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class ApiSecrets
    {
        public int Id { get; set; }
        public int ApiResourceId { get; set; }
        public string Description { get; set; }
        public DateTime? Expiration { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public ApiResources ApiResource { get; set; }
    }
}
