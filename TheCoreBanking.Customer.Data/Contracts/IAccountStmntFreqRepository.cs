using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IAccountStmntFreqRepository : IRepository<TblAccountstmntfreq>
    {
        IQueryable<TblAccountstmntfreq> GetActive();
    }
}
