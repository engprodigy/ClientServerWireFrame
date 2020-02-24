using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class SectorRepository : EFRepository<TblSector>, ISectorRepository
    {
        public SectorRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblSector> GetActive()
                => dbSet.Where(s => s.Isdeleted == false);

        public IQueryable<TblSector> GetSingleByNameOrCode(TblSector tblSector)
                => dbSet.Where(s => s.Name == tblSector.Name || s.Code == tblSector.Code);

        public IQueryable<TblSector> GetSingleByName(TblSector tblSector)
               => dbSet.Where(s => s.Name == tblSector.Name );

        public IQueryable<TblSector> GetSingleByCode(TblSector tblSector)
               => dbSet.Where(s => s.Code == tblSector.Code);
    }
}
