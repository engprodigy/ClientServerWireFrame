using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IAnnualIncomeRepository : IRepository<TblAnnualincome>
    {
        IQueryable<TblAnnualincome> GetBusinessType();

        IQueryable<TblAnnualincome> GetIndividualType();
    }
}