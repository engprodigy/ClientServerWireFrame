using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ICustomerAccountStmntMediaRepository : IRepository<TblCustomeraccountstmntmedium>
    {
        IQueryable<TblCustomeraccountstmntmedium> GetByAccountServiceID(int accountServiceID);
    }
}
