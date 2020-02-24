using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IMandateRepository : IRepository<TblMandate>
    {
        IQueryable<TblMandate> GetActive();
        IQueryable<TblMandate> GetByAccountId(int accountid);
    }
}
