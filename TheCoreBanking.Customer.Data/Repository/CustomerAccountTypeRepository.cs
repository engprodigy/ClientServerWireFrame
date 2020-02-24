using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerAccountTypeRepository : EFRepository<TblCustomeraccounttype>, ICustomerAccountTypeRepository
    {
        public CustomerAccountTypeRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblCustomeraccounttype> GetActive()
                => dbSet.Where(s => s.Isdeleted == false);
    }
}
