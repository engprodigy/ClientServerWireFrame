using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class KYCItemActionRepository : EFRepository<TblKycitemaction>, IKYCItemActionRepository
    {
        public KYCItemActionRepository(TheCoreBankingCustomerContext context) : base(context) { }
    }
}
