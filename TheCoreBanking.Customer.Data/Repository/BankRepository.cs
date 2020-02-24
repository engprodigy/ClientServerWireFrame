using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class BankRepository : EFRepository<TblBank>, IBankRepository
    {
        public BankRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblBank> GetActive() => dbSet.Where(bank => bank.Active == true);
    }
}
