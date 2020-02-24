using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IAccountBankingServiceRepository : IRepository<TblAccountbankingservice>
    {
        IQueryable<TblAccountbankingservice> GetActive();
    }
}
