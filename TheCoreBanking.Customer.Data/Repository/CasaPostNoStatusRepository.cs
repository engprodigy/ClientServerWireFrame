using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CasaPostNoStatusRepository : EFRepository<TblCasapostnostatus>, ICasaPostNoStatusRepository
    {
        public CasaPostNoStatusRepository(TheCoreBankingCustomerContext context): base(context) { }
    }
}
