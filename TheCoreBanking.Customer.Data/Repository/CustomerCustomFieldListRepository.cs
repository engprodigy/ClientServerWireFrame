using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerCustomFieldListRepository : EFRepository<TblCustomercustomfieldlist>, ICustomerCustomFieldListRepository
    {
        public CustomerCustomFieldListRepository(TheCoreBankingCustomerContext context) : base(context) { }

        //public IQueryable<TblBank> GetActive() => dbSet.Where(bank => bank.Active == true);
    }
}
