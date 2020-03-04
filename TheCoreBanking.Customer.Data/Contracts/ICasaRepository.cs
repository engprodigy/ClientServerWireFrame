using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ICasaRepository : IRepository<TblCasa>
    {
        IQueryable<TblCasa> GetDetailed();
        IQueryable<TblCasa> GetCurrent();
        IQueryable<TblCasa> GetChequeAccounts();
        TblCasa GetDetailedByAccountNo(string AccountNumber);
        TblCasa GetMandates(string AccountNumber);
        IQueryable<TblCasa> GetProductDetails(string AccountNumber);
        IQueryable<TblCasa> GetAccountWaitingForClosure();
        IQueryable<TblCasa> GetClosedAccount();
    }
}
