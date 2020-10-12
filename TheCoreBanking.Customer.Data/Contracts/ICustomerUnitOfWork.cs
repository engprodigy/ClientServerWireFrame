namespace TheCoreBanking.Customer.Data.Contracts
{
    /// <summary>
    /// Interface for the "Unit of Work"
    /// </summary>
    public interface ICustomerUnitOfWork
    {
        // Save pending changes to the data store.
        void Commit();

        // Repositories
    
       
        ICustomerRepository Customers { get; }
        



    }
}