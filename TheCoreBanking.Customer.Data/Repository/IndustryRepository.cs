using Microsoft.EntityFrameworkCore;
using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class IndustryRepository : EFRepository<TblIndustry>, IIndustryRepository
    {
        public IndustryRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblIndustry> GetDetailed()
            => dbSet.Include(i => i.Sector);

        public IQueryable<TblIndustry> GetActive()
            => dbSet.Where(s => s.Isdeleted == false)
                .Include(i => i.Sector);
    }
}
