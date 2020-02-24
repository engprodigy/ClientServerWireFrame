using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class SensitivityLevelRepository : EFRepository<TblSensitivitylevel>, ISensitivityLevelRepository
    {
        public SensitivityLevelRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblSensitivitylevel> GetActive() => dbSet.Where(l => l.Active == true);
    }
}
