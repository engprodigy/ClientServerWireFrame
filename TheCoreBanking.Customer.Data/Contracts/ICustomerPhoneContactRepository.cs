using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ICustomerPhoneContactRepository : IRepository<TblCustomerphonecontact>
    {
        IQueryable<TblCustomerphonecontact> GetByCustomerId(int customerID);
    }
}
