using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IMaritalStatusRepository : IRepository<TblMaritalstatus>
    {
        IQueryable<TblMaritalstatus> GetActive();
    }
}