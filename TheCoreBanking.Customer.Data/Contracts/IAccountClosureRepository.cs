using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
   public interface IAccountClosureRepository : IRepository<TblAccountclosure>
    {
        //decimal SPGLBalance(string accountNo);
        //decimal CustomerBalance(string accountNo);
        IQueryable<TblAccountclosure> GetByCustomerId(int customerID);
        IQueryable<TblAccountclosure> GetPendingToApproveForClosure();
        IQueryable<TblAccountclosure> GetAlreadyClosured();

        int InsertAccountClosure(string AccountNumber, decimal INTERESTAMOUNT, decimal SMSAMOUNT, decimal COTAMOUNT, decimal Charges, decimal AmountPayable, DateTime DateCreated, string CreatedBy, string CreditAccount, int OperationID, string Reference, string BranchCode, string CompanyCode, string Remark);

        decimal ClosedAcctAccruedCharges(string accountNumber, int types);

        //int listBranchAndCompany(string accountNumber);

         


    }
}
