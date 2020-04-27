using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CasaProductConversionTrackerRepository : EFRepository<TblCasaproductconversiontracker>, ICasaProductConversionTrackerRepository
    {
        public CasaProductConversionTrackerRepository(TheCoreBankingCustomerContext context) : base(context)
        {
        }
    }
}