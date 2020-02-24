using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IKycItemRepository : IRepository<TblKycitem>
    {
        IQueryable<TblKycitem> GetIndividualItems();
        IQueryable<TblKycitem> GetMinorItems();
        IQueryable<TblKycitem> GetCorporateItems();
        IQueryable<TblKycitem> GetJointItems();
        IQueryable<TblKycitem> GetEstateItems();
        IQueryable<TblKycitem> GetUnincorporatedItems();
        IQueryable<TblKycitem> GetActive();
    }
}
