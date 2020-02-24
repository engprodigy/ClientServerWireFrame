using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class BankAccountTypeRepository : EFRepository<TblBankaccounttype>, IBankAccountTypeRepository
    {
        public BankAccountTypeRepository(TheCoreBankingCustomerContext context) : base(context) { }
    }
}
