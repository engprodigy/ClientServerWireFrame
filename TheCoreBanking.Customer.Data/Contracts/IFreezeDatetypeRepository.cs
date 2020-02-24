using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IFreezeDatetypeRepository : IRepository<TblFreezedatetype>
    {
        IQueryable<TblFreezedatetype> ValidateFreezeDatatype(int ID);
    }
}
