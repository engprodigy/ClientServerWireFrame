using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class AccountStmntMediumRepository : EFRepository<TblAccountstmntmedium>, IAccountStmntMediumRepository
    {
        public AccountStmntMediumRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblAccountstmntmedium> GetActive() => dbSet.Where(m => m.Active == true);
    }
}
