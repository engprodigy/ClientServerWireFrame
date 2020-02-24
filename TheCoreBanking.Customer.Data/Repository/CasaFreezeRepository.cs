using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CasaFreezeRepository : EFRepository<TblCasafreeze>, ICasaFreezeRepository
    {
        public CasaFreezeRepository(TheCoreBankingCustomerContext context) : base(context) { }
    }
}
