using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace TheCoreBanking.Retail.Data.Models
{
    public partial class UploadImage
    {
        public List<IFormFile> UploadedFile{ get; set; }
        public string AccountNo { get; set; }
        public string ImageTitle { get; set; }
       
    }
}
