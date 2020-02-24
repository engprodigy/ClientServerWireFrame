using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerAccountServiceRepository : EFRepository<TblCustomeraccountservice>, ICustomerAccountServiceRepository
    {
        public CustomerAccountServiceRepository(TheCoreBankingCustomerContext context) : base(context) { }

    }
}
