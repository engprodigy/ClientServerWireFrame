using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class StaffInformationRepository : EFRepository<TblStaffInformation>, IStaffInformationRepository
    {
        public StaffInformationRepository(TheCoreBankingCustomerContext context) : base(context) { }


    }
}
