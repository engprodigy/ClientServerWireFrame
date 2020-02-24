
using System.Linq;
using TheCoreBanking.Customer.Data.Models;
using TheCoreBanking.Customer.Data.Repository;
using TheCoreBanking.Customer.Data.Contracts;

namespace TheCoreBanking.Customer.Data.Repository
{

    public class FreezeTransactionListRepository : EFRepository<TblFreezetransactionlist>, IFreezeTransactionListRepository
    {
        public FreezeTransactionListRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblFreezetransactionlist> ValidateFreezeTransactionList(int ID)
        {
            return dbSet.Where(ps => ps.Id == ID);
        }
    }
}
