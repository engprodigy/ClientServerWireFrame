using Microsoft.EntityFrameworkCore;
using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class ProductRepository : EFRepository<TblProduct>, IProductRepository
    {
        public ProductRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblProduct> GetDetailed()
            => dbSet.Include(ps => ps.Producttypeid)
                    .Include(ps => ps.Productcategoryid);

        public IQueryable<TblProduct> GetPrinciplaBalanceGLById(int? productId)
        
            => dbSet.Where(ps => ps.Id == productId);
        

    }
}

