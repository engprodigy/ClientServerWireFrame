using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;
using TheCoreBanking.Customer.Data.Repository;
using TheCoreBanking.Retail.Data.Repository;

namespace TheCoreBanking.Customer.Data.Helpers
{
    /// <summary>
    /// A maker of Code Camper Repositories.
    /// </summary>
    /// <remarks>
    /// An instance of this class contains repository factory functions for different types.
    /// Each factory function takes an EF <see cref="DbContext"/> and returns
    /// a repository bound to that DbContext.
    /// <para>
    /// Designed to be a "Singleton", configured at web application start with
    /// all of the factory functions needed to create any type of repository.
    /// Should be thread-safe to use because it is configured at app start,
    /// before any request for a factory, and should be immutable thereafter.
    /// </para>
    /// </remarks>
    public class RepositoryFactories
    {
        /// <summary>
        /// Return the runtime Code Camper repository factory functions,
        /// each one is a factory for a repository of a particular type.
        /// </summary>
        /// <remarks>
        /// MODIFY THIS METHOD TO ADD CUSTOM CODE CAMPER FACTORY FUNCTIONS
        /// </remarks>
        private IDictionary<Type, Func<TheCoreBankingCustomerContext, object>> GetFactories()
        {
            return new Dictionary<Type, Func<TheCoreBankingCustomerContext, object>>
            {
                {typeof(IAPIStubRepository), dbContext => new APIStubRepository(dbContext)},
                {typeof(ICustomerRepository), dbContext => new CustomerRepository(dbContext)},
                {typeof(IRegionRepository), dbContext => new RegionRepository(dbContext)},
                {typeof(ISectorRepository), dbContext => new SectorRepository(dbContext)},
                {typeof(ITitleRepository), dbContext => new TitleRepository(dbContext)},
                {typeof(IGenderRepository), dbContext => new GenderRepository(dbContext)},
                {typeof(IStateRepository), dbContext => new StateRepository(dbContext)},
                {typeof(IAnnualIncomeRepository), dbContext => new AnnualIncomeRepository(dbContext)},
                {typeof(IModeOfIDRepository), dbContext => new ModeOfIDRepository(dbContext)},
                {typeof(ICountryRepository), dbContext => new CountryRepository(dbContext)},
                {typeof(IMaritalStatusRepository), dbContext => new MaritalStatusRepository(dbContext)},
                {typeof(IStateLGARepository), dbContext => new StateLGARepository(dbContext)},
                {typeof(IEmploymentTypeRepository), dbContext => new EmploymentTypeRepository(dbContext)},
                {typeof(ISourceOfFundsRepository), dbContext => new SourceOfFundsRepository(dbContext)},
                {typeof(IBankRepository), dbContext => new BankRepository(dbContext)},
                {typeof(IBankAccountTypeRepository), dbContext => new BankAccountTypeRepository(dbContext)},
                {typeof(IBusinessCategoryRepository), dbContext => new BusinessCategoryRepository(dbContext)},
                {typeof(IKycItemRepository), dbContext => new KycItemRepository(dbContext)},
                {typeof(IKYCItemActionRepository), dbContext => new KYCItemActionRepository(dbContext)},
                {typeof(IInstitutionTypeRepository), dbContext => new InstitutionTypeRepository(dbContext)},
                {typeof(ICustomerAccountTypeRepository), dbContext => new CustomerAccountTypeRepository(dbContext)},
                {typeof(ICustomerAddressTypeRepository), dbContext => new CustomerAddressTypeRepository(dbContext)},
                {typeof(ICustomerAddressRepository), dbContext => new CustomerAddressRepository(dbContext)},
                {typeof(ICustomerPhoneContactRepository), dbContext => new CustomerPhoneContactRepository(dbContext)},
                {typeof(ICustomerEmailContactRepository), dbContext => new CustomerEmailContactRepository(dbContext)},
                {typeof(ICustomerAccountKYCItemRepository), dbContext => new CustomerAccountKYCItemRepository(dbContext)},
                {typeof(IIndustryRepository), dbContext => new IndustryRepository(dbContext)},
                {typeof(IAccountAlertMediumRepository), dbContext => new AccountAlertMediumRepository(dbContext)},
                {typeof(IAccountBankingServiceRepository), dbContext => new AccountBankingServiceRepository(dbContext)},
                {typeof(IAccountCardTypeRepository), dbContext => new AccountCardTypeRepository(dbContext)},
                {typeof(IAccountStmntFreqRepository), dbContext => new AccountStmntFreqRepository(dbContext)},
                {typeof(IAccountStmntMediumRepository), dbContext => new AccountStmntMediumRepository(dbContext)},
                {typeof(IDepartmentRepository), dbContext => new DepartmentRepository(dbContext)},
                {typeof(ISensitivityLevelRepository), dbContext => new SensitivityLevelRepository(dbContext)},
                {typeof(ICasaRepository), dbContext => new CasaRepository(dbContext)},
                {typeof(ICasaPostNoStatusRepository), dbContext => new CasaPostNoStatusRepository(dbContext)},
                {typeof(IMandateRepository), dbContext => new MandateRepository(dbContext)},
                {typeof(IAccountRefereeRepository), dbContext => new AccountRefereeRepository(dbContext)},
                {typeof(ICustomerAccountServiceRepository), dbContext => new CustomerAccountServiceRepository(dbContext)},
                {typeof(ICustomerAccountBankingServiceRepository), dbContext => new CustomerAccountBankingServiceRepository(dbContext)},
                {typeof(ICustomerAccountAlertMediaRepository), dbContext => new CustomerAccountAlertMediaRepository(dbContext)},
                {typeof(ICustomerAccountStmntMediaRepository), dbContext => new CustomerAccountStmntMediaRepository(dbContext)},
                {typeof(ICasaFreezeRepository), dbContext => new CasaFreezeRepository(dbContext)},
                {typeof(IProductRepository), dbContext => new ProductRepository(dbContext)},
                {typeof(IFreezetypeRepository), dbContext => new FreezeTypeRepository(dbContext)},
                {typeof(IFreezereasontypeRepository), dbContext => new FreezereasontypeRepository(dbContext)},
                {typeof(IFreezeDatetypeRepository), dbContext => new FreezeDatetypeRepository(dbContext)},
                {typeof(IFreezeTransactionListRepository), dbContext => new FreezeTransactionListRepository(dbContext)},
                {typeof(IAccountFreezeRepository), dbContext => new AccountFreezeRepository(dbContext)},
                {typeof(IDesignationRepository), dbContext => new DesignationRepository(dbContext)},
            };
        }

        /// <summary>
        /// Constructor that initializes with runtime Code Camper repository factories
        /// </summary>
        public RepositoryFactories()  
        {
            _repositoryFactories = GetFactories();
        }

        /// <summary>
        /// Constructor that initializes with an arbitrary collection of factories
        /// </summary>
        /// <param name="factories">
        /// The repository factory functions for this instance. 
        /// </param>
        /// <remarks>
        /// This ctor is primarily useful for testing this class
        /// </remarks>
        public RepositoryFactories(IDictionary<Type, Func<TheCoreBankingCustomerContext, object>> factories )
        {
            _repositoryFactories = factories;
        }

        /// <summary>
        /// Get the repository factory function for the type.
        /// </summary>
        /// <typeparam name="T">Type serving as the repository factory lookup key.</typeparam>
        /// <returns>The repository function if found, else null.</returns>
        /// <remarks>
        /// The type parameter, T, is typically the repository type 
        /// but could be any type (e.g., an entity type)
        /// </remarks>
        public Func<TheCoreBankingCustomerContext, object> GetRepositoryFactory<T>()
        {
       
            Func<TheCoreBankingCustomerContext, object> factory;
            _repositoryFactories.TryGetValue(typeof(T), out factory);
            return factory;
        }

        /// <summary>
        /// Get the factory for <see cref="IRepository{T}"/> where T is an entity type.
        /// </summary>
        /// <typeparam name="T">The root type of the repository, typically an entity type.</typeparam>
        /// <returns>
        /// A factory that creates the <see cref="IRepository{T}"/>, given an EF <see cref="DbContext"/>.
        /// </returns>
        /// <remarks>
        /// Looks first for a custom factory in <see cref="_repositoryFactories"/>.
        /// If not, falls back to the <see cref="DefaultEntityRepositoryFactory{T}"/>.
        /// You can substitute an alternative factory for the default one by adding
        /// a repository factory for type "T" to <see cref="_repositoryFactories"/>.
        /// </remarks>
        public Func<TheCoreBankingCustomerContext, object> GetRepositoryFactoryForEntityType<T>() where T : class
        {
            return GetRepositoryFactory<T>() ?? DefaultEntityRepositoryFactory<T>();
        }

        /// <summary>
        /// Default factory for a <see cref="IRepository{T}"/> where T is an entity.
        /// </summary>
        /// <typeparam name="T">Type of the repository's root entity</typeparam>
        protected virtual Func<TheCoreBankingCustomerContext, object> DefaultEntityRepositoryFactory<T>() where T : class
        {
            return dbContext => new EFRepository<T>(dbContext);
        }

        /// <summary>
        /// Get the dictionary of repository factory functions.
        /// </summary>
        /// <remarks>
        /// A dictionary key is a System.Type, typically a repository type.
        /// A value is a repository factory function
        /// that takes a <see cref="DbContext"/> argument and returns
        /// a repository object. Caller must know how to cast it.
        /// </remarks>
        private readonly IDictionary<Type, Func<TheCoreBankingCustomerContext, object>> _repositoryFactories;

    }
}
