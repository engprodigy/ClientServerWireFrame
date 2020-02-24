using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class InstitutionTypeRepository : EFRepository<TblInstitutiontype>, IInstitutionTypeRepository
    {
        public InstitutionTypeRepository(TheCoreBankingCustomerContext context) : base(context) { }
    }
}
