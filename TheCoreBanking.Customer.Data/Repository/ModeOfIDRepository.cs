using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class ModeOfIDRepository : EFRepository<TblModeofidentification>, IModeOfIDRepository
    {
        public ModeOfIDRepository(TheCoreBankingCustomerContext context) : base(context) {}

        public IQueryable<TblModeofidentification> GetActive()
               => dbSet.Where(s => s.Isdeleted == false);
    }
}