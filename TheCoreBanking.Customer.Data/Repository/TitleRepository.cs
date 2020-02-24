using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class TitleRepository : EFRepository<TblTitle>, ITitleRepository
    {
        public TitleRepository(TheCoreBankingCustomerContext context) : base(context) {}

        public IQueryable<TblTitle> GetActive()
                => dbSet.Where(t => t.Isdeleted == false);
    }
}