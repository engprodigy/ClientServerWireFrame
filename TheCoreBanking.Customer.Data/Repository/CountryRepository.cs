using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CountryRepository : EFRepository<TblCountry>, ICountryRepository
    {
        public CountryRepository(TheCoreBankingCustomerContext context) : base(context) { }
    }
}