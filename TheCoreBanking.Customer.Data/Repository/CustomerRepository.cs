using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
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

        public int CreateCustCode(long custId)
        {
            long result = 0;
            using (var context = new TheCoreBankingCustomerContext())
            {
                SqlParameter _ID = new SqlParameter("@ID", custId);


                result = context.Database.ExecuteSqlCommand("Customer.sp_GenerateCustCode @ID", _ID);
                return Convert.ToInt32(result);
            }
        }

    }
}