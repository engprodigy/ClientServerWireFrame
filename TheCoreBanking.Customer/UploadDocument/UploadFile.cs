using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheCoreBanking.Customer.UploadDocument
{

    public class UploadFile
    {
        public List<IFormFile> SecurityFile { get; set; }
        public string AttachmentTitle { get; set; }
        public string ProductAcctNo { get; set; }
    }
}
