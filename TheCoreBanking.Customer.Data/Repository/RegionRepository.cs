using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class RegionRepository : EFRepository<TblRegion>, IRegionRepository
    {
        public RegionRepository(TheCoreBankingCustomerContext context) : base(context)
        {
        }
    }
}