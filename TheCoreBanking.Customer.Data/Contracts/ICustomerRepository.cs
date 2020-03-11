using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ICustomerRepository : IRepository<TblCustomer>
    {
        IQueryable<TblCustomer> GetDetailed();
        int CreateCustCode(long custId);
    }
}