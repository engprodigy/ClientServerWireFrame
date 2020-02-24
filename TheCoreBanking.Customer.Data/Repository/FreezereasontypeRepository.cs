
using System.Linq;
using TheCoreBanking.Customer.Data.Models;
using TheCoreBanking.Customer.Data.Repository;
using TheCoreBanking.Customer.Data.Contracts;

namespace TheCoreBanking.Customer.Data.Repository
{

    public class FreezereasontypeRepository : EFRepository<TblFreezereasontype>, IFreezereasontypeRepository
    {
        public FreezereasontypeRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblFreezereasontype> ValidateFreezeReasonType(int ID)
        {
            return dbSet.Where(ps => ps.Id == ID);
        }

    }
}
