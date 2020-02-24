using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class SourceOfFundsRepository : EFRepository<TblSourceoffunds>, ISourceOfFundsRepository
    {
        public SourceOfFundsRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblSourceoffunds> GetActive() => dbSet.Where(source => !source.Deleted);
    }
}
