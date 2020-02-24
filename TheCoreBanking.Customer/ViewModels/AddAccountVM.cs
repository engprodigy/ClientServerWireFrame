using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheCoreBanking.Customer.Data.Models;
using TheCoreBanking.Customer.ModelBinders;

namespace TheCoreBanking.Customer.ViewModels
{
    public class AddAccountVM
    {
        public TblCasa Account { get; set; }
        public TblCustomeraccountservice AccountService { get; set; }
        public List<TblCustomeraccountbankingservice> BankingServices { get; set; }
        public List<TblCustomeraccountalertmedium> AlertMediums { get; set; }
        public List<TblCustomeraccountstmntmedium> StatementMediums { get; set; }
    }

    public class UpdateAccountVM
    {
        public TblCasa Account { get; set; }
        public TblCustomeraccountservice AccountService { get; set; }
        public List<int> BankingServiceids { get; set; }
        public List<int> AlertMediumids { get; set; }
        public List<int> StatementMediumids { get; set; }
    }

    public class AddSignatoryVM
    {
        [ModelBinder(BinderType = typeof(FormJsonBinder))]
        public TblMandate Data { get; set; }
        public IFormFile Passport { get; set; }
        public IFormFile Signature { get; set; }
        public IFormFile Thumbprint { get; set; }
    }

    public class AddRefereeVM
    {
        [ModelBinder(BinderType = typeof(FormJsonBinder))]
        public TblAccountreferee Data { get; set; }
        public IFormFile Document { get; set; }
    }

    public class AddMandateVM
    {
        [ModelBinder(BinderType = typeof(FormJsonBinder))]
        public TblMandate Data { get; set; }
        public IFormFile Mandate { get; set; }
        
    }

}