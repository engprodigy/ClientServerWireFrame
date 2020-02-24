using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IAccountRefereeRepository : IRepository<TblAccountreferee>
    {
        IQueryable<TblAccountreferee> GetByAccountId(int accountid);
    }
}
