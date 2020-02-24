using Microsoft.EntityFrameworkCore;
using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class KycItemRepository : EFRepository<TblKycitem>, IKycItemRepository
    {
        public KycItemRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblKycitem> GetCorporateItems()
            => dbSet.Include(item => item.Accounttype)
                .Where(item => item.Accounttype.Name == "Corporate")
                .OrderBy(item => item.Displayorder);

        public IQueryable<TblKycitem> GetEstateItems() 
            => dbSet.Include(item => item.Accounttype)
                .Where(item => item.Accounttype.Name == "Estate")
                .OrderBy(item => item.Displayorder);

        public IQueryable<TblKycitem> GetIndividualItems() 
            => dbSet.Include(item => item.Accounttype)
                .Where(item => item.Accounttype.Name == "Individual")
                .OrderBy(item => item.Displayorder);

        public IQueryable<TblKycitem> GetJointItems() 
            => dbSet.Include(item => item.Accounttype)
                .Where(item => item.Accounttype.Name == "Joint")
                .OrderBy(item => item.Displayorder);

        public IQueryable<TblKycitem> GetMinorItems() 
            => dbSet.Include(item => item.Accounttype)
                .Where(item => item.Accounttype.Name == "Minor")
                .OrderBy(item => item.Displayorder);

        public IQueryable<TblKycitem> GetUnincorporatedItems() 
            => dbSet.Include(item => item.Accounttype)
                .Where(item => item.Accounttype.Name == "Unincorporated")
                .OrderBy(item => item.Displayorder);

        public override IQueryable<TblKycitem> GetAll()
            => dbSet.Include(item => item.Accounttype)
                .OrderBy(item => item.Displayorder);

        public IQueryable<TblKycitem> GetActive()
            => dbSet.Include(item => item.Accounttype)
                .Where(s => s.Isdeleted == false)
                .OrderBy(item => item.Displayorder);
    }
}
