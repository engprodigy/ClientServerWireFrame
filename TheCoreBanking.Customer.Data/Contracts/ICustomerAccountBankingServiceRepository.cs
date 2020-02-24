using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ICustomerAccountBankingServiceRepository: IRepository<TblCustomeraccountbankingservice>
    {
        IQueryable<TblCustomeraccountbankingservice> GetByAccountServiceID(int accountServiceID);
    }
}
