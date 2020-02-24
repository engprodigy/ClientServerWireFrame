using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class AccountStmntFreqRepository : EFRepository<TblAccountstmntfreq>, IAccountStmntFreqRepository
    {
        public AccountStmntFreqRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblAccountstmntfreq> GetActive() => dbSet.Where(f => f.Active == true);
    }
}
