using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ICustomerEmailContactRepository : IRepository<TblCustomeremailcontact>
    {
        IQueryable<TblCustomeremailcontact> GetByCustomerId(int customerID);
    }
}
