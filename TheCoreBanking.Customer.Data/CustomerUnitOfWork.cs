using System;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Helpers;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Data
{
    public class CustomerUnitOfWork : ICustomerUnitOfWork, IDisposable
    {
        private readonly TheCoreBankingCustomerContext DbContext = new TheCoreBankingCustomerContext();
        private IRepositoryProvider RepositoryProvider { get; }

        // Define repository interfaces
       
        public ICustomerRepository Customers => GetEntityRepository<ICustomerRepository>();
        

        public CustomerUnitOfWork(IRepositoryProvider repositoryProvider)
        {
            repositoryProvider.DbContext = DbContext;
            RepositoryProvider = repositoryProvider; 
        }
        
        public void Commit()
        {
            DbContext.SaveChanges();
        }

        private IRepository<T> GetStandardRepository<T>() where T : class
        {
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }
        
        private T GetEntityRepository<T>() where T : class
        {
            return RepositoryProvider.GetRepository<T>();
        }
        
        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                }
            }
        }

        #endregion
    }
}