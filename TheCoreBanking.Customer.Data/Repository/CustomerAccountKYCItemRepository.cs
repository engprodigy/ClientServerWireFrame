using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerAccountKYCItemRepository : EFRepository<TblCustomeraccountkycitem>, ICustomerAccountKYCItemRepository
    {
        public CustomerAccountKYCItemRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblCustomeraccountkycitem> GetByCustomerId(int customerID) =>
            dbSet.Where(item => item.Customerid == customerID);
    }
}
