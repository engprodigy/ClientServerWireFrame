using System;
using System.Collections.Generic;
using System.Text;
using TheCoreBanking.Customer.Data.Models;
using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Repository;

namespace TheCoreBanking.Customer.Data.Repository
{

    public class BankingCasaRepository : EFRepository<TblBankingcasa>, IBankingCasaRepository
    {
        //private readonly TheCoreBankingCustomerContext _TheCoreBankingCustomerContext;
        public BankingCasaRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblBankingcasa> ValidateBankingCasa(int ID)
        {
            return dbSet.Where(ps => ps.Id == ID);
        }
        public TblBankingcasa GetByAccountNumber(string accountnumber)
        {
            return dbSet.SingleOrDefault(casa => casa.ProductAcctNo == accountnumber);
        }
    }
}
