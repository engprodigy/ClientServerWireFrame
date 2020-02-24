using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ICustomerAccountTypeRepository : IRepository<TblCustomeraccounttype>
    {
        IQueryable<TblCustomeraccounttype> GetActive();
    }
}
