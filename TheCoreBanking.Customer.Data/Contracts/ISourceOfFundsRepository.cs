using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ISourceOfFundsRepository : IRepository<TblSourceoffunds>
    {
        IQueryable<TblSourceoffunds> GetActive();
    }
}
