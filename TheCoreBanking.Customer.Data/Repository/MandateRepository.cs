using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class MandateRepository : EFRepository<TblMandate>, IMandateRepository
    {
        public MandateRepository(TheCoreBankingCustomerContext context): base(context) { }

        public IQueryable<TblMandate> GetActive()
            => dbSet/*.Where(m => m.)*/;
        
        public IQueryable<TblMandate> GetByAccountId(int accountid)
            => dbSet.Where(m => m.Casaaccountid == accountid)
                    .Where(m => m.Isdeleted == false);
    }
}
