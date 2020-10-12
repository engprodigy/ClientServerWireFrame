using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;


namespace TheCoreBanking.Customer.Controllers
{
    public class ProfileController : Controller
    {
        private ICustomerUnitOfWork CustomerUnitOfWork { get; }
        private readonly IHostingEnvironment hostingEnvironment;
        private ILogger<ProfileController> logger;

        public ProfileController(IHostingEnvironment hostingEnvironment, 
            ICustomerUnitOfWork uow, ILogger<ProfileController> profileLogger)
        {
            CustomerUnitOfWork = uow;
            this.hostingEnvironment = hostingEnvironment;
            logger = profileLogger;
        }

#if DEBUG
        //[Authorize()]
#else
            [Authorize()]
#endif
        public IActionResult Index()
        {
            logger.LogInformation("Index method called");
            return View();
        }

#if DEBUG
        //[Authorize()]
#else
            [Authorize()]
#endif
        public IActionResult KYCStatus()
        {
            return View();
        }
        
       

    }
}