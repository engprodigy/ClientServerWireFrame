using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IAccountCardTypeRepository : IRepository<TblAccountcardtype>
    {
        IQueryable<TblAccountcardtype> GetActive();
    }
}
