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
    public class CustomerCustomFieldRepository : EFRepository<TblCustomerCustomFields>, ICustomerCustomFieldRepository
    {
        public CustomerCustomFieldRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblCustomerCustomFields> ValidateCustomFields(int ID)
        {
            return dbSet.Where(p => p.Id == ID);
        }
    }
}
