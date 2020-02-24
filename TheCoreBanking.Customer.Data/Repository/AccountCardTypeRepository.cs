using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class AccountCardTypeRepository : EFRepository<TblAccountcardtype>, IAccountCardTypeRepository
    {
        public AccountCardTypeRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblAccountcardtype> GetActive() => dbSet.Where(c => c.Active == true);
    }
}
