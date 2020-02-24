using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;
using System.Linq;

namespace TheCoreBanking.Customer.Data.Repository
{

    public class BankingCustomerRepository : EFRepository<TblBankingcustomers>, IBankingCustomerRepository
    {
        //private readonly TheCoreBankingCustomerContext _TheCoreBankingCustomerContext;
        public BankingCustomerRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblBankingcustomers> ValidateBankingCustomer(int ID)
        {
            return dbSet.Where(ps => ps.Id == ID);
        }
    }
}
