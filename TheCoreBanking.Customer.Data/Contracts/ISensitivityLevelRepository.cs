using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ISensitivityLevelRepository : IRepository<TblSensitivitylevel>
    {
        IQueryable<TblSensitivitylevel> GetActive();
    }
}
