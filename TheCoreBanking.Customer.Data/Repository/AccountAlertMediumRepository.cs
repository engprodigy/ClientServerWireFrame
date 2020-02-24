using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class AccountAlertMediumRepository : EFRepository<TblAccountalertmedium>, IAccountAlertMediumRepository
    {
        public AccountAlertMediumRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblAccountalertmedium> GetActive() => dbSet.Where(m => m.Active == true);
    }
}
