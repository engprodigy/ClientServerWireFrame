using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IProductRepository : IRepository<TblProduct>
    {
        IQueryable<TblProduct> GetDetailed();
        IQueryable<TblProduct> GetPrinciplaBalanceGLById(int? productId);
        //object GetPrinciplaBalanceGLById(int? productId);
    }
}
