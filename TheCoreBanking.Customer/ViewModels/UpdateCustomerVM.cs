using System;
using System.Collections.Generic;
using TheCoreBanking.Customer.Data.Models;
using Microsoft.AspNetCore.Http;


namespace TheCoreBanking.Customer.ViewModels
{
    public class UpdateCustomerVM
    {


        public TblCustomer customer;
        public List<TblCustomeraccountkycitem> kyc;
       
    }
}
