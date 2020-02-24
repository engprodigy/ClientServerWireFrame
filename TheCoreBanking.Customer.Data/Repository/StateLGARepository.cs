using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class StateLGARepository : EFRepository<TblStateandlga>, IStateLGARepository
    {
        public StateLGARepository(TheCoreBankingCustomerContext context) : base(context) { }
    }
}
