using Microsoft.EntityFrameworkCore;
using System.Linq;
using TheCoreBanking.Customer.Data.Enums;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CasaRepository : EFRepository<TblCasa>, ICasaRepository
    {
        public CasaRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblCasa> GetDetailed()
            => dbSet.Include(casa => casa.Accountstatus)
                    .Include(casa => casa.TblAccountreferee)
                    .Include(casa => casa.TblMandate)
                    .Include(casa => casa.TblCustomeraccountservice)
                        .ThenInclude(service => service.TblCustomeraccountalertmedium)
                    .Include(casa => casa.TblCustomeraccountservice)
                        .ThenInclude(service => service.TblCustomeraccountbankingservice)
                    .Include(casa => casa.TblCustomeraccountservice)
                        .ThenInclude(service => service.TblCustomeraccountstmntmedium);

        public TblCasa GetDetailedByAccountNo(string AccountNumber)
            => dbSet.Include(casa => casa.Accountstatus)
                    .Include(casa => casa.TblCustomeraccountservice)
                        .ThenInclude(service => service.TblCustomeraccountalertmedium)
                    .Include(casa => casa.TblCustomeraccountservice)
                        .ThenInclude(service => service.TblCustomeraccountbankingservice)
                    .Include(casa => casa.TblCustomeraccountservice)
                        .ThenInclude(service => service.TblCustomeraccountstmntmedium)
                    .SingleOrDefault(casa => casa.Accountnumber == AccountNumber);

        public IQueryable<TblCasa> GetCurrent()
            => dbSet.Where(c => c.Iscurrentaccount == true);

        public IQueryable<TblCasa> GetChequeAccounts()
            => dbSet.Where(c => c.Iscurrentaccount == true)
                    .Where(c => c.Postnostatusid != (int) AccountPostingStatus.POSTNODEBIT 
                        && c.Postnostatusid != (int) AccountPostingStatus.POSTNOCREDITANDDEBIT)
                    .Where(c => c.Accountstatusid != (int) AccountStatusEnum.DORMANT 
                        && c.Accountstatusid != (int) AccountStatusEnum.CLOSED
                        && c.Accountstatusid != (int) AccountStatusEnum.FROZEN);

        public TblCasa GetMandates(string AccountNumber)
            => dbSet.Include(casa => casa.TblMandate)
                    .SingleOrDefault(casa => casa.Accountnumber == AccountNumber);

        public IQueryable<TblCasa> GetProductDetails(string AccountNumber)
                 // => dbSet.Include(casa => casa.Product)
                 => dbSet.Where(casa => casa.Accountnumber == AccountNumber);


        public IQueryable<TblCasa> GetAccountWaitingForClosure()
        {
            //return  dbSet.Where(c => c.Accountstatusid != (int)AccountStatusEnum.CLOSED);
            return dbSet.Where(c => c.Accountstatusid != 4);
        }

        public IQueryable<TblCasa> GetClosedAccount()
        {
            return dbSet.Where(c => c.Accountstatusid == (int)AccountStatusEnum.CLOSED);
        }

    }
}
