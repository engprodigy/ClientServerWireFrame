using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerPhoneContactRepository : EFRepository<TblCustomerphonecontact>, ICustomerPhoneContactRepository
    {
        public CustomerPhoneContactRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblCustomerphonecontact> GetActive() => dbSet.Where(phone => phone.Active == true);

        public IQueryable<TblCustomerphonecontact> GetByCustomerId(int customerID) =>
            dbSet.Where(phone => phone.Active == true)
                .Where(phone => phone.Customerid == customerID);
    }
}
