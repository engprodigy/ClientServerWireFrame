using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class GenderRepository : EFRepository<TblGender>, IGenderRepository
    {
        public GenderRepository(TheCoreBankingCustomerContext context) : base(context)
        {
        }
    }
}