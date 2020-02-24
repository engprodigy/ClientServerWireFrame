using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IAccountAlertMediumRepository : IRepository<TblAccountalertmedium>
    {
        IQueryable<TblAccountalertmedium> GetActive();
    }
}
