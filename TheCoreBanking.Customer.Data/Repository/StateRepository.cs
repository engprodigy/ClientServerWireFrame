using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class StateRepository : EFRepository<TblState>, IStateRepository
    {
        public StateRepository(TheCoreBankingCustomerContext context) : base(context)
        {
        }
    }
}