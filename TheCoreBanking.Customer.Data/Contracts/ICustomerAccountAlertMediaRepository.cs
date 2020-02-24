using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ICustomerAccountAlertMediaRepository : IRepository<TblCustomeraccountalertmedium>
    {
        IQueryable<TblCustomeraccountalertmedium> GetByAccountServiceID(int accountServiceID);
    }
}
