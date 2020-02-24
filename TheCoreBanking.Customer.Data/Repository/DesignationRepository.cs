using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class DesignationRepository : EFRepository<TblDesignation>, IDesignationRepository
    {

        public DesignationRepository(TheCoreBankingCustomerContext context) : base(context) { }

    }
}
