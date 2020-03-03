using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IChartofAccountRepository : IRepository<TblFinanceChartOfAccount>
    {
        IQueryable<TblFinanceChartOfAccount> ValidateChart(string ID);
    }
}
