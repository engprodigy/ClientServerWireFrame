using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class MaritalStatusRepository : EFRepository<TblMaritalstatus>, IMaritalStatusRepository
    {
        public MaritalStatusRepository(TheCoreBankingCustomerContext context) : base(context) {}

        public IQueryable<TblMaritalstatus> GetActive()
                => dbSet.Where(s => s.Isdeleted == false);
    }
}