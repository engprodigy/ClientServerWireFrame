using System;
using System.Collections.Generic;
using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TheCoreBanking.Customer.Data.ProcedureAndFunctionDTO;
using TheCoreBanking.Customer.Data.Enums;
using System.Runtime.InteropServices;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class AccountClosureRepository : EFRepository<TblAccountclosure>, IAccountClosureRepository
    {
        
        public AccountClosureRepository(TheCoreBankingCustomerContext context) : base(context) { }

       

        public IQueryable<TblAccountclosure> GetByCustomerId(int customerID)
        {
            return dbSet.Where(p => p.Id == customerID);
        }

        public IQueryable<TblAccountclosure> GetPendingToApproveForClosure()
        {
            return dbSet.Where(p => p.Approved == false);
        }
        public IQueryable<TblAccountclosure> GetAlreadyClosured()
        {
            return dbSet.Where(p => p.Approved == true);
        }

        public int InsertAccountClosure(string AccountNumber, decimal INTERESTAMOUNT, decimal SMSAMOUNT, decimal COTAMOUNT, decimal Charges, decimal AmountPayable, DateTime DateCreated, string CreatedBy, string CreditAccount, int OperationID, string Reference, string BranchCode, string CompanyCode, string Remark)
        {
           
           // var result = 1;
          

            using (var context = new TheCoreBankingCustomerContext())
            {
                SqlParameter _AccountNumber = new SqlParameter("@AccountNumber", AccountNumber);
                SqlParameter _INTERESTAMOUNT = new SqlParameter("@INTERESTAMOUNT", INTERESTAMOUNT);
                SqlParameter _SMSAMOUNT = new SqlParameter("@SMSAMOUNT", SMSAMOUNT);
                SqlParameter _COTAMOUNT = new SqlParameter("@COTAMOUNT", COTAMOUNT);
                SqlParameter _Charges = new SqlParameter("@Charges", Charges);
                SqlParameter _AmountPayable = new SqlParameter("@AmountPayable", AmountPayable);           
                SqlParameter _DateCreated = new SqlParameter("@DateCreated", DateCreated);
                SqlParameter _CreatedBy = new SqlParameter("@CreatedBy", CreatedBy);
                SqlParameter _CreditAccount = new SqlParameter("@CreditAccount", CreditAccount);
                SqlParameter _OperationID = new SqlParameter("@OperationID", OperationID);
                SqlParameter _Reference = new SqlParameter("@Reference", Reference);
                SqlParameter _BranchCode = new SqlParameter("@BranchCode", BranchCode);
                SqlParameter _CompanyCode = new SqlParameter("@CompanyCode", CompanyCode);
                SqlParameter _Remark = new SqlParameter("@Remark", Remark);
             
                
                return context.Database.ExecuteSqlCommand("InsertAccountClosure @AccountNumber,@INTERESTAMOUNT, @SMSAMOUNT,@COTAMOUNT,@Charges,@AmountPayable,@DateCreated,@DateCreated,@CreatedBy,@CreditAccount,@OperationID,@Reference,@BranchCode,@CompanyCode,@Remark",_AccountNumber, _INTERESTAMOUNT,_SMSAMOUNT, _COTAMOUNT, _Charges, _AmountPayable, _DateCreated, _CreatedBy, _CreditAccount, _OperationID, _Reference, _BranchCode, _CompanyCode, _Remark);

                 
            }
           // return result;


        }

      

        public decimal ClosedAcctAccruedCharges(string accountNumber, [Optional] int type)
        {
            ChargesPending accrued = new ChargesPending();

            using (var context = new TheCoreBankingCustomerContext())
            {
                SqlParameter AcctNo = new SqlParameter("@AcctNo", accountNumber);
                SqlParameter Type = new SqlParameter("@Type", type);
                //SqlParameter id = new SqlParameter("@Id", Id);


                accrued = context.ChargesPendings.FromSql("Customer.ACCRUDECHARGES @AcctNo, @Type", AcctNo, Type).Single();
              

               // List<ChargesPending> result = context.ChargesPendings.FromSql("GetValuesWithoutIds").AsNoTracking().ToList();

            }
            return Convert.ToDecimal(accrued.pendings);           
        }



        //public decimal SPGLBalance(string accountNo)
        //{
        //    var GLBalance = new GLBalance();
        //    using (var context = new TheCoreBankingCustomerContext())
        //    {
        //        SqlParameter AcctNo = new SqlParameter("@AccountID", accountNo);

        //        GLBalance = context.GLBalance.FromSql("General.GetGLBalance2 @AccountID", AcctNo).Single();
                
        //    }
        //    return GLBalance.GLBalances;
        //}

        //public decimal CustomerBalance(string accountNo)
        //{
        //    try
        //    {
        //        var GetCustomerBalance = new GetCustomerBalance();
        //        using (var context = new TheCoreBankingCustomerContext())
        //        {
        //            SqlParameter AcctNo = new SqlParameter("@AccountNumber", accountNo);
        //            //decimal? Balance = 0;
        //            GetCustomerBalance = context.GetCustomerBalance.FromSql("dbo.GetCustomerBalance @AccountNumber", AcctNo).FirstOrDefault();
        //            return GetCustomerBalance.GetCustomerBalances;
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        return 0;
        //    }


        //}

    

       
    }
}
