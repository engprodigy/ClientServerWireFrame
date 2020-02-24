using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.ViewModels
{
   

    public class AccompanyDocumentVM
    {
        public IFormFile Document { get; set; }
        public string Title { get; set; }
    }
}