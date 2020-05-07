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
    
        IAPIStubRepository API { get; }
        ICustomerRepository Customers { get; }
        IRegionRepository Regions { get; }
        ISectorRepository Sectors { get; }
        ITitleRepository Titles { get; }
        IGenderRepository Genders { get; }
        IStateRepository States { get; }
        IAnnualIncomeRepository AnnualIncomes { get; }
        IModeOfIDRepository ModeOfIDs { get; }
        ICountryRepository Countries { get; }
        IMaritalStatusRepository MaritalStatuses { get; }
        IStateLGARepository StateLGAs { get; }
        IEmploymentTypeRepository EmploymentTypes { get; }
        ISourceOfFundsRepository SourceOfFunds { get; }
        IBankRepository Banks { get; }
        IBankAccountTypeRepository BankAccountTypes { get; }
        IBusinessCategoryRepository BusinessCategories { get; }
        IKycItemRepository KYCItems { get; }
        IKYCItemActionRepository KYCItemActions { get; }
        IInstitutionTypeRepository InstitutionTypes { get; }
        ICustomerAccountTypeRepository CustomerAccountTypes { get; }
        ICustomerAddressTypeRepository AddressTypes { get; }
        ICustomerAddressRepository CustomerAddresses { get; }
        ICustomerEmailContactRepository CustomerEmails { get; }
        ICustomerPhoneContactRepository CustomerPhones { get; }
        ICustomerAccountKYCItemRepository CustomerKYCItems { get; }
        IIndustryRepository Industries { get; }
        IAccountAlertMediumRepository AlertMedia { get; }
        IAccountBankingServiceRepository BankingServices { get; }
        IAccountCardTypeRepository CardTypes { get; }
        IAccountStmntFreqRepository StatementFrequencies { get; }
        IAccountStmntMediumRepository StatementMedia { get; }
        IDepartmentRepository Departments { get; }
        ISensitivityLevelRepository SensitivityLevels { get; }
        ICasaRepository Accounts { get; }
        ICasaPostNoStatusRepository AccountPostStatuses { get; }
        ICustomerAccountServiceRepository AccountServices { get; }
        ICustomerAccountAlertMediaRepository AccountAlertMedia { get; }
        ICustomerAccountBankingServiceRepository AccountBankingServices { get; }
        ICustomerAccountStmntMediaRepository AccountStatementMedia { get; }
        IMandateRepository Mandates { get; }
        IAccountRefereeRepository AccountReferees { get; }
        ICasaFreezeRepository CASAFreezes { get; }
        IProductRepository Product { get; }
        IBankingCustomerRepository Customer { get; }
        IBankingCasaRepository Casa { get; }
        IAccountFreezeRepository AccountFreeze { get; }
        IFreezeDatetypeRepository FreezeDatetype { get; }
        IFreezeTransactionListRepository FreezeTransaction { get; }
        IFreezetypeRepository Freezetype { get; }
        IFreezereasontypeRepository Reasontype { get; }
        ICustomerCustomFieldRepository CustomFields { get; }
        IDesignationRepository Designation { get; }
        IAccountClosureRepository ClosuredAccount { get; }

        IChartofAccountRepository Chart { get; }
        ICasaProductConversionTrackerRepository CasaProductConversionTracker { get; }
        ICustomerCustomFieldListRepository CustomerCustomFieldList { get; }
        ICustomerCustomFieldOptionsRepository CustomerCustomFieldOptions { get; }
    }
}