using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class AccountBankingServiceRepository : EFRepository<TblAccountbankingservice>, IAccountBankingServiceRepository
    {
        public AccountBankingServiceRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblAccountbankingservice> GetActive() => dbSet.Where(s => s.Active == true);
    }
}
