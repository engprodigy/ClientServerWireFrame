using System;
using System.Collections.Generic;
using System.Text;
using TheCoreBanking.Customer.Data.Contracts;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TheCoreBanking.Customer.Data.Models;
using TheCoreBanking.Customer.Data.Repository;

namespace TheCoreBanking.Customer.Data.Repository
{
   public class AccountFreezeRepository : EFRepository<TblAccountfreeze>, IAccountFreezeRepository
    {
        public AccountFreezeRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblAccountfreeze> ValidateAccountfreeze(int ID)
        {
            return dbSet.Where(p => p.Id == ID);
        }
    }
}
