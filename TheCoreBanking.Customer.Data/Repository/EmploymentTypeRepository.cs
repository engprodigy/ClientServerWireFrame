using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class EmploymentTypeRepository : EFRepository<TblEmploymenttype>, IEmploymentTypeRepository
    {
        public EmploymentTypeRepository(TheCoreBankingCustomerContext context) : base (context) { }
    }
}
