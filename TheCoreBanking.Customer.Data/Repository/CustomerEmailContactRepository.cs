using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerEmailContactRepository : EFRepository<TblCustomeremailcontact>, ICustomerEmailContactRepository
    {
        public CustomerEmailContactRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblCustomeremailcontact> GetActive() => dbSet.Where(email => email.Active == true);

        public IQueryable<TblCustomeremailcontact> GetByCustomerId(int customerID) =>
            dbSet.Where(email => email.Active == true)
                .Where(email => email.Customerid == customerID);
    }
}
