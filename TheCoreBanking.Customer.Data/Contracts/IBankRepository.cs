﻿using System.Linq;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data.Contracts
{
    public interface IBankRepository : IRepository<TblBank>
    {
        IQueryable<TblBank> GetActive();
    }
}
