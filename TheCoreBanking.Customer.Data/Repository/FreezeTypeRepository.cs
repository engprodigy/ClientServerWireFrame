
using System.Linq;
using TheCoreBanking.Customer.Data.Models;
using TheCoreBanking.Customer.Data.Repository;
using TheCoreBanking.Customer.Data.Contracts;

namespace TheCoreBanking.Customer.Data.Repository
{

    public class FreezeTypeRepository : EFRepository<TblFreezetype>, IFreezetypeRepository
    {
        public FreezeTypeRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblFreezetype> ValidateFreezeType(int ID)
        {
            return dbSet.Where(ps => ps.Id == ID);
        }
    }
}
