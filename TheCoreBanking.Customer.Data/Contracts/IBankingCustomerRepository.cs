using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TheCoreBanking.Customer.Data.Models;


namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IBankingCustomerRepository : IRepository<TblBankingcustomers>
    {
        IQueryable<TblBankingcustomers> ValidateBankingCustomer(int ID);
    }
}
