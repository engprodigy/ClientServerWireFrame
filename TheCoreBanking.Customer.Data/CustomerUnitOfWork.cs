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
        public IAPIStubRepository API => GetEntityRepository<IAPIStubRepository>();
        public ICustomerRepository Customers => GetEntityRepository<ICustomerRepository>();
        public IRegionRepository Regions => GetEntityRepository<IRegionRepository>();
        public ISectorRepository Sectors => GetEntityRepository<ISectorRepository>();
        public ITitleRepository Titles => GetEntityRepository<ITitleRepository>();
        public IGenderRepository Genders => GetEntityRepository<IGenderRepository>();
        public IStateRepository States => GetEntityRepository<IStateRepository>();
        public IAnnualIncomeRepository AnnualIncomes => GetEntityRepository<IAnnualIncomeRepository>();
        public IModeOfIDRepository ModeOfIDs => GetEntityRepository<IModeOfIDRepository>();
        public ICountryRepository Countries => GetEntityRepository<ICountryRepository>();
        public IMaritalStatusRepository MaritalStatuses => GetEntityRepository<IMaritalStatusRepository>();
        public IStateLGARepository StateLGAs => GetEntityRepository<IStateLGARepository>();
        public IEmploymentTypeRepository EmploymentTypes => GetEntityRepository<IEmploymentTypeRepository>();
        public ISourceOfFundsRepository SourceOfFunds => GetEntityRepository<ISourceOfFundsRepository>();
        public IBankRepository Banks => GetEntityRepository<IBankRepository>();
        public IBankAccountTypeRepository BankAccountTypes => GetEntityRepository<IBankAccountTypeRepository>();
        public IBusinessCategoryRepository BusinessCategories => GetEntityRepository<IBusinessCategoryRepository>();
        public IKycItemRepository KYCItems => GetEntityRepository<IKycItemRepository>();
        public IKYCItemActionRepository KYCItemActions => GetEntityRepository<IKYCItemActionRepository>();
        public IInstitutionTypeRepository InstitutionTypes => GetEntityRepository<IInstitutionTypeRepository>();
        public ICustomerAccountTypeRepository CustomerAccountTypes => GetEntityRepository<ICustomerAccountTypeRepository>();
        public ICustomerAddressTypeRepository AddressTypes => GetEntityRepository<ICustomerAddressTypeRepository>();
        public ICustomerAddressRepository CustomerAddresses => GetEntityRepository<ICustomerAddressRepository>();
        public ICustomerEmailContactRepository CustomerEmails => GetEntityRepository<ICustomerEmailContactRepository>();
        public ICustomerPhoneContactRepository CustomerPhones => GetEntityRepository<ICustomerPhoneContactRepository>();
        public ICustomerAccountKYCItemRepository CustomerKYCItems => GetEntityRepository<ICustomerAccountKYCItemRepository>();
        public IIndustryRepository Industries => GetEntityRepository<IIndustryRepository>();
        public IAccountAlertMediumRepository AlertMedia => GetEntityRepository<IAccountAlertMediumRepository>();
        public IAccountBankingServiceRepository BankingServices => GetEntityRepository<IAccountBankingServiceRepository>();
        public IAccountCardTypeRepository CardTypes => GetEntityRepository<IAccountCardTypeRepository>();
        public IAccountStmntFreqRepository StatementFrequencies => GetEntityRepository<IAccountStmntFreqRepository>();
        public IAccountStmntMediumRepository StatementMedia => GetEntityRepository<IAccountStmntMediumRepository>();
        public IDepartmentRepository Departments => GetEntityRepository<IDepartmentRepository>();
        public ISensitivityLevelRepository SensitivityLevels => GetEntityRepository<ISensitivityLevelRepository>();
        public ICasaRepository Accounts => GetEntityRepository<ICasaRepository>();
        public ICasaPostNoStatusRepository AccountPostStatuses => GetEntityRepository<ICasaPostNoStatusRepository>();
        public IMandateRepository Mandates => GetEntityRepository<IMandateRepository>();
        public IAccountRefereeRepository AccountReferees => GetEntityRepository<IAccountRefereeRepository>();
        public ICustomerAccountServiceRepository AccountServices => GetEntityRepository<ICustomerAccountServiceRepository>();
        public ICustomerAccountAlertMediaRepository AccountAlertMedia => GetEntityRepository<ICustomerAccountAlertMediaRepository>();
        public ICustomerAccountStmntMediaRepository AccountStatementMedia => GetEntityRepository<ICustomerAccountStmntMediaRepository>();
        public ICustomerAccountBankingServiceRepository AccountBankingServices => GetEntityRepository<ICustomerAccountBankingServiceRepository>();
        public ICasaFreezeRepository CASAFreezes => GetEntityRepository<ICasaFreezeRepository>();
        //public IProductRepository Product { get { return GetEntityRepository<IProductRepository>(); } 
        public IProductRepository Product => GetEntityRepository<IProductRepository>();
        public IBankingCustomerRepository Customer { get { return GetEntityRepository<IBankingCustomerRepository>(); } }
        public IBankingCasaRepository Casa { get { return GetEntityRepository<IBankingCasaRepository>(); } }
        public IAccountFreezeRepository AccountFreeze { get { return GetEntityRepository<IAccountFreezeRepository>(); } }
        public IFreezeDatetypeRepository FreezeDatetype { get { return GetEntityRepository<IFreezeDatetypeRepository>(); } }
        public IFreezeTransactionListRepository FreezeTransaction { get { return GetEntityRepository<IFreezeTransactionListRepository>(); } }
        public IFreezetypeRepository Freezetype { get { return GetEntityRepository<IFreezetypeRepository>(); } }
        public IFreezereasontypeRepository Reasontype { get { return GetEntityRepository<IFreezereasontypeRepository>(); } }
        public ICustomerCustomFieldRepository CustomFields { get { return GetEntityRepository<ICustomerCustomFieldRepository>(); } }
        public IDesignationRepository Designation { get { return GetEntityRepository<IDesignationRepository>(); } }

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