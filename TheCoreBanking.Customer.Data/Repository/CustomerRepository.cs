using Microsoft.EntityFrameworkCore;
using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerRepository : EFRepository<TblCustomer>, ICustomerRepository
    {
        public CustomerRepository(TheCoreBankingCustomerContext context) : base(context) {}

        public IQueryable<TblCustomer> GetDetailed()
            => dbSet //.Where(c => c.Customerid == 3) // && c.Customerid == 9)
                .Include(c => c.Customeraccounttype)
                      .Include(c => c.TblCustomeraccountkycitem)
                          .ThenInclude(ki => ki.Action)    //;
                            .OrderByDescending(c=>c.Customerid).Take(10);

       

    }
}