using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface ICustomerCustomFieldOptionsRepository : IRepository<TblCustomercustomfieldoptions>
    {
       // IQueryable<TblCustomerCustomFields> ValidateCustomFields(int ID);
    }
}
