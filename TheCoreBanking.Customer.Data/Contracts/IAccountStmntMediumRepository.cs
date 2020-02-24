using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IAccountStmntMediumRepository : IRepository<TblAccountstmntmedium>
    {
        IQueryable<TblAccountstmntmedium> GetActive();
    }
}
