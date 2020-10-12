using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerRepository : EFRepository<TblCustomer>, ICustomerRepository
    {
        public CustomerRepository(TheCoreBankingCustomerContext context) : base(context) {}

       

       

    }
}