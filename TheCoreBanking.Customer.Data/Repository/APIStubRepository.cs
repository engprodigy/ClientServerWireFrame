using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;
using TheCoreBanking.Customer.Data.Repository;

namespace TheCoreBanking.Retail.Data.Repository
{
    public class APIStubRepository : EFRepository<APIStubModel>, IAPIStubRepository
    {
        public APIStubRepository(TheCoreBankingCustomerContext context) : base(context) { }
    }

    
}
