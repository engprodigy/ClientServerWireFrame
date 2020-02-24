using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerAddressTypeRepository : EFRepository<TblCustomeraddresstype>, ICustomerAddressTypeRepository
    {
        public CustomerAddressTypeRepository(TheCoreBankingCustomerContext context) : base(context) { }
    }
}
