using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TheCoreBanking.Customer.Data.Models;


namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IBankingCasaRepository : IRepository<TblBankingcasa>
    {
        IQueryable<TblBankingcasa> ValidateBankingCasa(int ID);
        TblBankingcasa GetByAccountNumber(string accountnumber);
    }
}
