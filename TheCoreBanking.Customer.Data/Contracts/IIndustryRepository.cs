using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IIndustryRepository : IRepository<TblIndustry>
    {
        IQueryable<TblIndustry> GetDetailed();

        IQueryable<TblIndustry> GetActive();
    }
}
