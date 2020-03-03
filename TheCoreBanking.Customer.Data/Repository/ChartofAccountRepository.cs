using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class ChartofAccountRepository : EFRepository<TblFinanceChartOfAccount>, IChartofAccountRepository
    {
        public ChartofAccountRepository(TheCoreBankingCustomerContext context) : base(context) { }     


        public IQueryable<TblFinanceChartOfAccount> ValidateChart(string ID)
        {
            return dbSet.Where(ps => ps.AccountId == ID);
        }

        //public IRetailUnitOfWork RetailUnitOfWork { get; set; }

        ////For Stored Procedure
        //public bool SPGLBalance(string AccountId)
        //{
        //    var result = false;
        //    using (var context = new TheCoreBankingRetailContext())
        //    {
        //        SqlParameter ProductAcctNo = new SqlParameter("@AccountID", AccountId);

        //        context.Database.ExecuteSqlCommand("General.GetGLBalance @AccountID", ProductAcctNo);
        //        result = true;
        //    }
        //    return result;
        //}
    }
}
