using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ISectorRepository : IRepository<TblSector>
    {
        IQueryable<TblSector> GetActive();
        IQueryable<TblSector> GetSingleByNameOrCode(TblSector tblSector);
        IQueryable<TblSector> GetSingleByName(TblSector tblSector);
        IQueryable<TblSector> GetSingleByCode(TblSector tblSector);
    }
}
