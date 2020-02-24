using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class FreezeDatetypeRepository : EFRepository<TblFreezedatetype>, IFreezeDatetypeRepository
    {
        public FreezeDatetypeRepository(TheCoreBankingCustomerContext context) : base(context) { }
        public IQueryable<TblFreezedatetype> ValidateFreezeDatatype(int ID)
        {
            return dbSet.Where(ps => ps.Id == ID);
        }
    }
}
