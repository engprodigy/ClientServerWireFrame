using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class AnnualIncomeRepository : EFRepository<TblAnnualincome>, IAnnualIncomeRepository
    {
        public AnnualIncomeRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblAnnualincome> GetBusinessType() => dbSet.Where(i => i.Accounttype == "Business");

        public IQueryable<TblAnnualincome> GetIndividualType() => dbSet.Where(i => i.Accounttype == "Individual");

    }

}