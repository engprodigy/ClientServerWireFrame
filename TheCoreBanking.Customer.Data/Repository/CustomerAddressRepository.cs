using Microsoft.EntityFrameworkCore;
using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Repository
{
    public class CustomerAddressRepository : EFRepository<TblCustomeraddress>, ICustomerAddressRepository
    {
        public CustomerAddressRepository(TheCoreBankingCustomerContext context) : base(context) { }

        public IQueryable<TblCustomeraddress> GetActive() => 
            dbSet.Where(address => address.Active == true);

        public IQueryable<TblCustomeraddress> GetDetailedByCustomerId(int customerID) =>
            dbSet.Include(address => address.Addresstype)
                .Include(address => address.State)
                .Include(address => address.Country)
                .Where(address => address.Active == true)
                .Where(address => address.Customerid == customerID);
    }
}
