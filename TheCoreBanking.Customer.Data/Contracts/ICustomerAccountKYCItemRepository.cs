using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ICustomerAccountKYCItemRepository : IRepository<TblCustomeraccountkycitem>
    {
        IQueryable<TblCustomeraccountkycitem> GetByCustomerId(int customerID);
    }
}
