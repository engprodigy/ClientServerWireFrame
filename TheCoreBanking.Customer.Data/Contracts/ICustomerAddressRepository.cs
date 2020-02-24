using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ICustomerAddressRepository : IRepository<TblCustomeraddress>
    {
        IQueryable<TblCustomeraddress> GetDetailedByCustomerId(int customerID);

        IQueryable<TblCustomeraddress> GetActive();
    }
}
