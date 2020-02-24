using Microsoft.EntityFrameworkCore;
using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerAccountBankingServiceRepository : EFRepository<TblCustomeraccountbankingservice>, ICustomerAccountBankingServiceRepository
    {
        public CustomerAccountBankingServiceRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblCustomeraccountbankingservice> GetByAccountServiceID(int accountServiceID)
            => dbSet.Where(bankingservice => bankingservice.Customeraccountserviceid == accountServiceID);
    }
}
