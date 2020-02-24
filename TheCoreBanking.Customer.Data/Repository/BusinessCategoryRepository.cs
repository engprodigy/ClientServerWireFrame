using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class BusinessCategoryRepository : EFRepository<TblBusinesscategory>, IBusinessCategoryRepository
    {
        public BusinessCategoryRepository(TheCoreBankingCustomerContext context) : base(context) { }
    }
}
