using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerAccountStmntMediaRepository : EFRepository<TblCustomeraccountstmntmedium>, ICustomerAccountStmntMediaRepository
    {
        public CustomerAccountStmntMediaRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblCustomeraccountstmntmedium> GetByAccountServiceID(int accountServiceID)
            => dbSet.Where(bankingservice => bankingservice.Customeraccountserviceid == accountServiceID);
    }
}
