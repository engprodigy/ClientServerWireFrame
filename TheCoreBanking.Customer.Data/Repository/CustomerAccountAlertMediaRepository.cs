using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerAccountAlertMediaRepository : EFRepository<TblCustomeraccountalertmedium>, ICustomerAccountAlertMediaRepository
    {
        public CustomerAccountAlertMediaRepository(TheCoreBankingCustomerContext context): base(context) { }

        public IQueryable<TblCustomeraccountalertmedium> GetByAccountServiceID(int accountServiceID)
            => dbSet.Where(bankingservice => bankingservice.Customeraccountserviceid == accountServiceID);
    }
}
