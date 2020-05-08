﻿using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerCustomFieldOptionsRepository : EFRepository<TblCustomercustomfieldoptions>, ICustomerCustomFieldOptionsRepository
    {
        public CustomerCustomFieldOptionsRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblCustomercustomfieldoptions> GetOptions(int id) => dbSet.Where(options => options.CustomerCustomFieldListId == id);
    }
}