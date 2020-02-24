using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class DepartmentRepository : EFRepository<TblDepartment>, IDepartmentRepository
    {
        public DepartmentRepository(TheCoreBankingCustomerContext context) : base(context) { }
    }
}
