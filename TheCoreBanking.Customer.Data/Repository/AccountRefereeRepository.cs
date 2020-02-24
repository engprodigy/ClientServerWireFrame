using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class AccountRefereeRepository : EFRepository<TblAccountreferee>, IAccountRefereeRepository
    {
        public AccountRefereeRepository(TheCoreBankingCustomerContext context) : base(context) { }
        public IQueryable<TblAccountreferee> GetByAccountId(int accountid)
            => dbSet.Where(r => r.Casaaccountid == accountid)
                    .Where(r => r.Isdeleted == false);
    }
}
