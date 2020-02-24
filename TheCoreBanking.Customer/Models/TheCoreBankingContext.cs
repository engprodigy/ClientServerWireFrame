using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TheCoreBanking.Customer.Models
{
    public partial class TheCoreBankingContext : DbContext
    {
        public virtual DbSet<ApiClaims> ApiClaims { get; set; }
        public virtual DbSet<ApiResources> ApiResources { get; set; }
        public virtual DbSet<ApiScopeClaims> ApiScopeClaims { get; set; }
        public virtual DbSet<ApiScopes> ApiScopes { get; set; }
        public virtual DbSet<ApiSecrets> ApiSecrets { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<ClientClaims> ClientClaims { get; set; }
        public virtual DbSet<ClientCorsOrigins> ClientCorsOrigins { get; set; }
        public virtual DbSet<ClientGrantTypes> ClientGrantTypes { get; set; }
        public virtual DbSet<ClientIdPrestrictions> ClientIdPrestrictions { get; set; }
        public virtual DbSet<ClientPostLogoutRedirectUris> ClientPostLogoutRedirectUris { get; set; }
        public virtual DbSet<ClientProperties> ClientProperties { get; set; }
        public virtual DbSet<ClientRedirectUris> ClientRedirectUris { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<ClientScopes> ClientScopes { get; set; }
        public virtual DbSet<ClientSecrets> ClientSecrets { get; set; }
        public virtual DbSet<FinanceBankingDefaultAccounts> FinanceBankingDefaultAccounts { get; set; }
        public virtual DbSet<IdentityClaims> IdentityClaims { get; set; }
        public virtual DbSet<IdentityResources> IdentityResources { get; set; }
        public virtual DbSet<PersistedGrants> PersistedGrants { get; set; }
        public virtual DbSet<TblAccountalertmedium> TblAccountalertmedium { get; set; }
        public virtual DbSet<TblAccountbankingservice> TblAccountbankingservice { get; set; }
        public virtual DbSet<TblAccountcardtype> TblAccountcardtype { get; set; }
        public virtual DbSet<TblAccountchequeconfirmation> TblAccountchequeconfirmation { get; set; }
        public virtual DbSet<TblAccountreferee> TblAccountreferee { get; set; }
        public virtual DbSet<TblAccountstmntfreq> TblAccountstmntfreq { get; set; }
        public virtual DbSet<TblAccountstmntmedium> TblAccountstmntmedium { get; set; }
        public virtual DbSet<TblAnnualincome> TblAnnualincome { get; set; }
        public virtual DbSet<TblApprovalstatus> TblApprovalstatus { get; set; }
        public virtual DbSet<TblBank> TblBank { get; set; }
        public virtual DbSet<TblBankaccounttype> TblBankaccounttype { get; set; }
        public virtual DbSet<TblBankdraftsetup> TblBankdraftsetup { get; set; }
        public virtual DbSet<TblBankingAccumulatedInterest> TblBankingAccumulatedInterest { get; set; }
        public virtual DbSet<TblBankingAccumulatedInterestHistory> TblBankingAccumulatedInterestHistory { get; set; }
        public virtual DbSet<TblBankingAdjustedScheduleApproval> TblBankingAdjustedScheduleApproval { get; set; }
        public virtual DbSet<TblBankingAllBanks> TblBankingAllBanks { get; set; }
        public virtual DbSet<TblBankingApprovalTrack> TblBankingApprovalTrack { get; set; }
        public virtual DbSet<TblBankingApprovalTrack1> TblBankingApprovalTrack1 { get; set; }
        public virtual DbSet<TblBankingCadeposit> TblBankingCadeposit { get; set; }
        public virtual DbSet<TblBankingChangeRepaymentDate> TblBankingChangeRepaymentDate { get; set; }
        public virtual DbSet<TblBankingChangeSchedule> TblBankingChangeSchedule { get; set; }
        public virtual DbSet<TblBankingCommittee> TblBankingCommittee { get; set; }
        public virtual DbSet<TblBankingCotsetup> TblBankingCotsetup { get; set; }
        public virtual DbSet<TblBankingCreditArchivedInterest> TblBankingCreditArchivedInterest { get; set; }
        public virtual DbSet<TblBankingCreditArchivedInterestHistory> TblBankingCreditArchivedInterestHistory { get; set; }
        public virtual DbSet<TblBankingCreditRepaymentNdmb> TblBankingCreditRepaymentNdmb { get; set; }
        public virtual DbSet<TblBankingCustomerFees> TblBankingCustomerFees { get; set; }
        public virtual DbSet<TblBankingCustomerSecurity> TblBankingCustomerSecurity { get; set; }
        public virtual DbSet<TblBankingDailyInterestAccrued> TblBankingDailyInterestAccrued { get; set; }
        public virtual DbSet<TblBankingDailyInterestAccruedHistory> TblBankingDailyInterestAccruedHistory { get; set; }
        public virtual DbSet<TblBankingInterestSuspension> TblBankingInterestSuspension { get; set; }
        public virtual DbSet<TblBankingLoanApplication> TblBankingLoanApplication { get; set; }
        public virtual DbSet<TblBankingLoanCancelation> TblBankingLoanCancelation { get; set; }
        public virtual DbSet<TblBankingLoanChecklist> TblBankingLoanChecklist { get; set; }
        public virtual DbSet<TblBankingLoanLease> TblBankingLoanLease { get; set; }
        public virtual DbSet<TblBankingLoanWalkOut> TblBankingLoanWalkOut { get; set; }
        public virtual DbSet<TblBankingOperationSetup> TblBankingOperationSetup { get; set; }
        public virtual DbSet<TblBankingoperationtype> TblBankingoperationtype { get; set; }
        public virtual DbSet<TblBankingOperativeAccounts> TblBankingOperativeAccounts { get; set; }
        public virtual DbSet<TblBankingPrincipalAddition> TblBankingPrincipalAddition { get; set; }
        public virtual DbSet<TblBankingPrincipalReduction> TblBankingPrincipalReduction { get; set; }
        public virtual DbSet<TblBankingProduct> TblBankingProduct { get; set; }
        public virtual DbSet<TblBankingProductAccountCriteria> TblBankingProductAccountCriteria { get; set; }
        public virtual DbSet<TblBankingProductFees> TblBankingProductFees { get; set; }
        public virtual DbSet<TblBankingProductFeesList> TblBankingProductFeesList { get; set; }
        public virtual DbSet<TblBankingProductFeesListLoanMapping> TblBankingProductFeesListLoanMapping { get; set; }
        public virtual DbSet<TblBankingProductSecurity> TblBankingProductSecurity { get; set; }
        public virtual DbSet<TblBankingProductSecurityList> TblBankingProductSecurityList { get; set; }
        public virtual DbSet<TblBankingProductType> TblBankingProductType { get; set; }
        public virtual DbSet<TblBankingRestructure> TblBankingRestructure { get; set; }
        public virtual DbSet<TblBankingReviseRate> TblBankingReviseRate { get; set; }
        public virtual DbSet<TblBankingSecurityWorth> TblBankingSecurityWorth { get; set; }
        public virtual DbSet<TblBankingsinglefundtransfer> TblBankingsinglefundtransfer { get; set; }
        public virtual DbSet<TblBankingSuspenseAccount> TblBankingSuspenseAccount { get; set; }
        public virtual DbSet<TblBankingTermination> TblBankingTermination { get; set; }
        public virtual DbSet<TblBankingTillfunction> TblBankingTillfunction { get; set; }
        public virtual DbSet<TblBranch> TblBranch { get; set; }
        public virtual DbSet<TblBusinesscategory> TblBusinesscategory { get; set; }
        public virtual DbSet<TblCasa> TblCasa { get; set; }
        public virtual DbSet<TblCasaaccountstatus> TblCasaaccountstatus { get; set; }
        public virtual DbSet<TblCasafreeze> TblCasafreeze { get; set; }
        public virtual DbSet<TblCasapostnostatus> TblCasapostnostatus { get; set; }
        public virtual DbSet<TblCasaTest> TblCasaTest { get; set; }
        public virtual DbSet<TblChequebookdetail> TblChequebookdetail { get; set; }
        public virtual DbSet<TblChequebooktype> TblChequebooktype { get; set; }
        public virtual DbSet<TblChequecharges> TblChequecharges { get; set; }
        public virtual DbSet<TblChequeleafstatus> TblChequeleafstatus { get; set; }
        public virtual DbSet<TblChequeleavesdetail> TblChequeleavesdetail { get; set; }
        public virtual DbSet<TblCity> TblCity { get; set; }
        public virtual DbSet<TblClearingoptions> TblClearingoptions { get; set; }
        public virtual DbSet<TblCompany> TblCompany { get; set; }
        public virtual DbSet<TblCompanyclass> TblCompanyclass { get; set; }
        public virtual DbSet<TblCompanytype> TblCompanytype { get; set; }
        public virtual DbSet<TblCotsetup> TblCotsetup { get; set; }
        public virtual DbSet<TblCountry> TblCountry { get; set; }
        public virtual DbSet<TblCreditAppraisalAttachment> TblCreditAppraisalAttachment { get; set; }
        public virtual DbSet<TblCreditAppraisalGrade> TblCreditAppraisalGrade { get; set; }
        public virtual DbSet<TblCreditAppraisalGroup> TblCreditAppraisalGroup { get; set; }
        public virtual DbSet<TblCreditAppraisalGroupProfile> TblCreditAppraisalGroupProfile { get; set; }
        public virtual DbSet<TblCreditAppraisalLevel> TblCreditAppraisalLevel { get; set; }
        public virtual DbSet<TblCreditAppraisalLevelProfile> TblCreditAppraisalLevelProfile { get; set; }
        public virtual DbSet<TblCreditAppraisalMemorandum> TblCreditAppraisalMemorandum { get; set; }
        public virtual DbSet<TblCreditAppraisalMemorandumTemplate> TblCreditAppraisalMemorandumTemplate { get; set; }
        public virtual DbSet<TblCreditAppraisalOfficers> TblCreditAppraisalOfficers { get; set; }
        public virtual DbSet<TblCreditAppraisalPhase> TblCreditAppraisalPhase { get; set; }
        public virtual DbSet<TblCreditAppraisalProduct> TblCreditAppraisalProduct { get; set; }
        public virtual DbSet<TblCreditAppraisalProfile> TblCreditAppraisalProfile { get; set; }
        public virtual DbSet<TblCreditAppraisalStatus> TblCreditAppraisalStatus { get; set; }
        public virtual DbSet<TblCreditAppraisalStatusDescription> TblCreditAppraisalStatusDescription { get; set; }
        public virtual DbSet<TblCreditAppraisalUserGroupMapping> TblCreditAppraisalUserGroupMapping { get; set; }
        public virtual DbSet<TblCreditAppraisalUserLevelMapping> TblCreditAppraisalUserLevelMapping { get; set; }
        public virtual DbSet<TblCreditAppraisalUserProfile> TblCreditAppraisalUserProfile { get; set; }
        public virtual DbSet<TblCreditAssessmentFactorIndex> TblCreditAssessmentFactorIndex { get; set; }
        public virtual DbSet<TblCreditAssessmentIndex> TblCreditAssessmentIndex { get; set; }
        public virtual DbSet<TblCreditAssessmentIndexTitle> TblCreditAssessmentIndexTitle { get; set; }
        public virtual DbSet<TblCreditAssessmentRiskFactor> TblCreditAssessmentRiskFactor { get; set; }
        public virtual DbSet<TblCreditAssessmentRiskRating> TblCreditAssessmentRiskRating { get; set; }
        public virtual DbSet<TblCreditAssessmentRiskRatingResult> TblCreditAssessmentRiskRatingResult { get; set; }
        public virtual DbSet<TblCurrency> TblCurrency { get; set; }
        public virtual DbSet<TblCustomer> TblCustomer { get; set; }
        public virtual DbSet<TblCustomeraccountalertmedium> TblCustomeraccountalertmedium { get; set; }
        public virtual DbSet<TblCustomeraccountbankingservice> TblCustomeraccountbankingservice { get; set; }
        public virtual DbSet<TblCustomeraccountkycitem> TblCustomeraccountkycitem { get; set; }
        public virtual DbSet<TblCustomeraccountservice> TblCustomeraccountservice { get; set; }
        public virtual DbSet<TblCustomeraccountstmntmedium> TblCustomeraccountstmntmedium { get; set; }
        public virtual DbSet<TblCustomeraccounttype> TblCustomeraccounttype { get; set; }
        public virtual DbSet<TblCustomeraddress> TblCustomeraddress { get; set; }
        public virtual DbSet<TblCustomeraddresstype> TblCustomeraddresstype { get; set; }
        public virtual DbSet<TblCustomerblacklist> TblCustomerblacklist { get; set; }
        public virtual DbSet<TblCustomerbvn> TblCustomerbvn { get; set; }
        public virtual DbSet<TblCustomerCustomFields> TblCustomerCustomFields { get; set; }
        public virtual DbSet<TblCustomeremailcontact> TblCustomeremailcontact { get; set; }
        public virtual DbSet<TblCustomeremploymenthistory> TblCustomeremploymenthistory { get; set; }
        public virtual DbSet<TblCustomergroup> TblCustomergroup { get; set; }
        public virtual DbSet<TblCustomeridentification> TblCustomeridentification { get; set; }
        public virtual DbSet<TblCustomeridentimodetype> TblCustomeridentimodetype { get; set; }
        public virtual DbSet<TblCustomernextofkin> TblCustomernextofkin { get; set; }
        public virtual DbSet<TblCustomerphonecontact> TblCustomerphonecontact { get; set; }
        public virtual DbSet<TblCustomersignatory> TblCustomersignatory { get; set; }
        public virtual DbSet<TblDepartment> TblDepartment { get; set; }
        public virtual DbSet<TblEditedcustomer> TblEditedcustomer { get; set; }
        public virtual DbSet<TblEmploymenttype> TblEmploymenttype { get; set; }
        public virtual DbSet<TblFinanceAccountCategory> TblFinanceAccountCategory { get; set; }
        public virtual DbSet<TblFinanceAccountGroup> TblFinanceAccountGroup { get; set; }
        public virtual DbSet<TblFinanceAccountSub> TblFinanceAccountSub { get; set; }
        public virtual DbSet<TblFinanceAccountType> TblFinanceAccountType { get; set; }
        public virtual DbSet<TblFinanceAccountType1> TblFinanceAccountType1 { get; set; }
        public virtual DbSet<TblFinanceBank> TblFinanceBank { get; set; }
        public virtual DbSet<TblFinanceBankReconciliation> TblFinanceBankReconciliation { get; set; }
        public virtual DbSet<TblFinanceBankStatementsItems> TblFinanceBankStatementsItems { get; set; }
        public virtual DbSet<TblFinanceBonuses> TblFinanceBonuses { get; set; }
        public virtual DbSet<TblFinanceBonusesGeneral> TblFinanceBonusesGeneral { get; set; }
        public virtual DbSet<TblFinanceChartOfAccount> TblFinanceChartOfAccount { get; set; }
        public virtual DbSet<TblFinanceCostCenter> TblFinanceCostCenter { get; set; }
        public virtual DbSet<TblFinanceCounterpartyTransaction> TblFinanceCounterpartyTransaction { get; set; }
        public virtual DbSet<TblFinanceCurrency> TblFinanceCurrency { get; set; }
        public virtual DbSet<TblFinanceCurrentDate> TblFinanceCurrentDate { get; set; }
        public virtual DbSet<TblFinanceDefaultAccounts> TblFinanceDefaultAccounts { get; set; }
        public virtual DbSet<TblFinanceGlmapping> TblFinanceGlmapping { get; set; }
        public virtual DbSet<TblFinanceStatus> TblFinanceStatus { get; set; }
        public virtual DbSet<TblFinanceTransaction> TblFinanceTransaction { get; set; }
        public virtual DbSet<TblGender> TblGender { get; set; }
        public virtual DbSet<TblGrantreversalprivilege> TblGrantreversalprivilege { get; set; }
        public virtual DbSet<TblIndustry> TblIndustry { get; set; }
        public virtual DbSet<TblInsertcustomerprofile> TblInsertcustomerprofile { get; set; }
        public virtual DbSet<TblInstitutiontype> TblInstitutiontype { get; set; }
        public virtual DbSet<TblInwardbankcheque> TblInwardbankcheque { get; set; }
        public virtual DbSet<TblKycdocumenttype> TblKycdocumenttype { get; set; }
        public virtual DbSet<TblKycitem> TblKycitem { get; set; }
        public virtual DbSet<TblKycitemaction> TblKycitemaction { get; set; }
        public virtual DbSet<TblMaintenanceaccountdetails> TblMaintenanceaccountdetails { get; set; }
        public virtual DbSet<TblMaintenancetrack> TblMaintenancetrack { get; set; }
        public virtual DbSet<TblMandate> TblMandate { get; set; }
        public virtual DbSet<TblMaritalstatus> TblMaritalstatus { get; set; }
        public virtual DbSet<TblMmarketFrozenCallAccount> TblMmarketFrozenCallAccount { get; set; }
        public virtual DbSet<TblMmarketUnfrozenCallAccount> TblMmarketUnfrozenCallAccount { get; set; }
        public virtual DbSet<TblModeofidentification> TblModeofidentification { get; set; }
        public virtual DbSet<TblMultipleAccountToCreditFundTransfer> TblMultipleAccountToCreditFundTransfer { get; set; }
        public virtual DbSet<TblMultipleAccountToDebitFundTransfer> TblMultipleAccountToDebitFundTransfer { get; set; }
        public virtual DbSet<TblNatureofbusiness> TblNatureofbusiness { get; set; }
        public virtual DbSet<TblOperationtype> TblOperationtype { get; set; }
        public virtual DbSet<TblOutwardbankcheque> TblOutwardbankcheque { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }
        public virtual DbSet<TblProductCategory> TblProductCategory { get; set; }
        public virtual DbSet<TblProductGroup> TblProductGroup { get; set; }
        public virtual DbSet<TblRegion> TblRegion { get; set; }
        public virtual DbSet<TblRetailoperationtype> TblRetailoperationtype { get; set; }
        public virtual DbSet<TblScheduleSimulation> TblScheduleSimulation { get; set; }
        public virtual DbSet<TblSector> TblSector { get; set; }
        public virtual DbSet<TblSensitivitylevel> TblSensitivitylevel { get; set; }
        public virtual DbSet<TblSingleFundTransfer> TblSingleFundTransfer { get; set; }
        public virtual DbSet<TblSourceoffunds> TblSourceoffunds { get; set; }
        public virtual DbSet<TblStaff> TblStaff { get; set; }
        public virtual DbSet<TblStaffInfo> TblStaffInfo { get; set; }
        public virtual DbSet<TblStaffInformation> TblStaffInformation { get; set; }
        public virtual DbSet<TblStaffjobtitle> TblStaffjobtitle { get; set; }
        public virtual DbSet<TblStaffrank> TblStaffrank { get; set; }
        public virtual DbSet<TblStampcharge> TblStampcharge { get; set; }
        public virtual DbSet<TblState> TblState { get; set; }
        public virtual DbSet<TblStateandlga> TblStateandlga { get; set; }
        public virtual DbSet<TblSubsector> TblSubsector { get; set; }
        public virtual DbSet<TblSystemnarration> TblSystemnarration { get; set; }
        public virtual DbSet<TblTellercloselimitsetup> TblTellercloselimitsetup { get; set; }
        public virtual DbSet<TblTellerlimit> TblTellerlimit { get; set; }
        public virtual DbSet<TblTellerlogin> TblTellerlogin { get; set; }
        public virtual DbSet<TblTellersetup> TblTellersetup { get; set; }
        public virtual DbSet<TblTempBankingUpdateSchedule> TblTempBankingUpdateSchedule { get; set; }
        public virtual DbSet<TblTilldefinition> TblTilldefinition { get; set; }
        public virtual DbSet<TblTillimit> TblTillimit { get; set; }
        public virtual DbSet<TblTilllimitsetup> TblTilllimitsetup { get; set; }
        public virtual DbSet<TblTillmapping> TblTillmapping { get; set; }
        public virtual DbSet<TblTilltfunction> TblTilltfunction { get; set; }
        public virtual DbSet<TblTilltype> TblTilltype { get; set; }
        public virtual DbSet<TblTitle> TblTitle { get; set; }
        public virtual DbSet<TblTransfercharge> TblTransfercharge { get; set; }
        public virtual DbSet<TblTreasurySecurity> TblTreasurySecurity { get; set; }
        public virtual DbSet<TblTreasuryTt> TblTreasuryTt { get; set; }
        public virtual DbSet<TsCreditType> TsCreditType { get; set; }
        public virtual DbSet<TsFinanceCurrentDate> TsFinanceCurrentDate { get; set; }
        //public virtual DbSet<TblDesignation> TblDesignation { get; set; }
        
        // Unable to generate entity type for table 'dbo.tbl_OperationalPayable'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_OperationalReceivable'. Please see the warning messages.
        // Unable to generate entity type for table 'Credit.tbl_BankingSameDayReversal'. Please see the warning messages.
        // Unable to generate entity type for table 'Credit.tbl_BankingSchMethod'. Please see the warning messages.
        // Unable to generate entity type for table 'Credit.tbl_BankingTempSchedule'. Please see the warning messages.
        // Unable to generate entity type for table 'Credit.tbl_BankingUpdateSchedule'. Please see the warning messages.
        // Unable to generate entity type for table 'Credit.tbl_BankingUpdateScheduleHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'GeneralSetup.tbl_BankingCustomerPrivilege'. Please see the warning messages.
        // Unable to generate entity type for table 'Product.tbl_Stocks'. Please see the warning messages.
        // Unable to generate entity type for table 'Finance.tbl_FinanceBankReconciliationDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'Credit.tbl_BankingDisbursement'. Please see the warning messages.
        // Unable to generate entity type for table 'Finance.tbl_TransferCharge'. Please see the warning messages.
        // Unable to generate entity type for table 'Finance.tbl_TransferChargeType'. Please see the warning messages.
        // Unable to generate entity type for table 'FinancialReport.ifrs_registry'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_BankingCommittee'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-5VJ567N\FINTRAKSQL;Database=TheCoreBanking;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiClaims>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.ApiResource)
                    .WithMany(p => p.ApiClaims)
                    .HasForeignKey(d => d.ApiResourceId);
            });

            modelBuilder.Entity<ApiResources>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ApiScopeClaims>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.ApiScope)
                    .WithMany(p => p.ApiScopeClaims)
                    .HasForeignKey(d => d.ApiScopeId);
            });

            modelBuilder.Entity<ApiScopes>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.ApiResource)
                    .WithMany(p => p.ApiScopes)
                    .HasForeignKey(d => d.ApiResourceId);
            });

            modelBuilder.Entity<ApiSecrets>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Type).HasMaxLength(250);

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.ApiResource)
                    .WithMany(p => p.ApiSecrets)
                    .HasForeignKey(d => d.ApiResourceId);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.TblStaffInformationId).HasColumnName("tblStaffInformationId");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ClientClaims>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientClaims)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientCorsOrigins>(entity =>
            {
                entity.Property(e => e.Origin)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientCorsOrigins)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientGrantTypes>(entity =>
            {
                entity.Property(e => e.GrantType)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientGrantTypes)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientIdPrestrictions>(entity =>
            {
                entity.ToTable("ClientIdPRestrictions");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientIdPrestrictions)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientPostLogoutRedirectUris>(entity =>
            {
                entity.Property(e => e.PostLogoutRedirectUri)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientPostLogoutRedirectUris)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientProperties>(entity =>
            {
                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientProperties)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientRedirectUris>(entity =>
            {
                entity.Property(e => e.RedirectUri)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientRedirectUris)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.Property(e => e.BackChannelLogoutUri).HasMaxLength(2000);

                entity.Property(e => e.ClientClaimsPrefix).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ClientName).HasMaxLength(200);

                entity.Property(e => e.ClientUri).HasMaxLength(2000);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.FrontChannelLogoutUri).HasMaxLength(2000);

                entity.Property(e => e.LogoUri).HasMaxLength(2000);

                entity.Property(e => e.PairWiseSubjectSalt).HasMaxLength(200);

                entity.Property(e => e.ProtocolType)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ClientScopes>(entity =>
            {
                entity.Property(e => e.Scope)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientScopes)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientSecrets>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Type).HasMaxLength(250);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientSecrets)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<FinanceBankingDefaultAccounts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasColumnName("AccountID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IdentityClaims>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.IdentityResource)
                    .WithMany(p => p.IdentityClaims)
                    .HasForeignKey(d => d.IdentityResourceId);
            });

            modelBuilder.Entity<IdentityResources>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PersistedGrants>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasMaxLength(200)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblAccountalertmedium>(entity =>
            {
                entity.ToTable("TBL_ACCOUNTALERTMEDIUM", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .HasColumnName("ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Alerttype)
                    .IsRequired()
                    .HasColumnName("ALERTTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccountbankingservice>(entity =>
            {
                entity.ToTable("TBL_ACCOUNTBANKINGSERVICE", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .HasColumnName("ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccountcardtype>(entity =>
            {
                entity.ToTable("TBL_ACCOUNTCARDTYPE", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .HasColumnName("ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Cardname)
                    .IsRequired()
                    .HasColumnName("CARDNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccountchequeconfirmation>(entity =>
            {
                entity.ToTable("TBL_ACCOUNTCHEQUECONFIRMATION", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .HasColumnName("ACCOUNTNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Beneficiaryname)
                    .HasColumnName("BENEFICIARYNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branchcode)
                    .HasColumnName("BRANCHCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Chequeno)
                    .HasColumnName("CHEQUENO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Companycode)
                    .HasColumnName("COMPANYCODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Confirmedby)
                    .HasColumnName("CONFIRMEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Confirmedfrom)
                    .HasColumnName("CONFIRMEDFROM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateconfirmed)
                    .HasColumnName("DATECONFIRMED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Phonenumber)
                    .HasColumnName("PHONENUMBER")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccountreferee>(entity =>
            {
                entity.HasKey(e => e.Refereeid);

                entity.ToTable("TBL_ACCOUNTREFEREE", "Customer");

                entity.Property(e => e.Refereeid).HasColumnName("REFEREEID");

                entity.Property(e => e.Accountname)
                    .HasColumnName("ACCOUNTNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Accountno)
                    .HasColumnName("ACCOUNTNO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Bankaddress)
                    .HasColumnName("BANKADDRESS")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Casaaccountid).HasColumnName("CASAACCOUNTID");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasColumnName("FULLNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasColumnName("RELATIONSHIP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Casaaccount)
                    .WithMany(p => p.TblAccountreferee)
                    .HasForeignKey(d => d.Casaaccountid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_ACCOUNTREFEREE_TBL_CASA");
            });

            modelBuilder.Entity<TblAccountstmntfreq>(entity =>
            {
                entity.ToTable("TBL_ACCOUNTSTMNTFREQ", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .HasColumnName("ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasColumnName("FREQUENCY")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccountstmntmedium>(entity =>
            {
                entity.ToTable("TBL_ACCOUNTSTMNTMEDIUM", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .HasColumnName("ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Statementmedium)
                    .IsRequired()
                    .HasColumnName("STATEMENTMEDIUM")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAnnualincome>(entity =>
            {
                entity.ToTable("TBL_ANNUALINCOME", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accounttype)
                    .IsRequired()
                    .HasColumnName("ACCOUNTTYPE")
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Range)
                    .IsRequired()
                    .HasColumnName("RANGE")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblApprovalstatus>(entity =>
            {
                entity.ToTable("TBL_APPROVALSTATUS", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBank>(entity =>
            {
                entity.ToTable("TBL_BANK", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .HasColumnName("ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankaccounttype>(entity =>
            {
                entity.ToTable("TBL_BANKACCOUNTTYPE", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accounttype)
                    .IsRequired()
                    .HasColumnName("ACCOUNTTYPE")
                    .HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<TblBankdraftsetup>(entity =>
            {
                entity.HasKey(e => e.Bankdraftid);

                entity.ToTable("TBL_BANKDRAFTSETUP", "Retail");

                entity.Property(e => e.Bankdraftid).HasColumnName("BANKDRAFTID");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Chartofaccountid).HasColumnName("CHARTOFACCOUNTID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Destinationbranchid).HasColumnName("DESTINATIONBRANCHID");

                entity.Property(e => e.Interestgl).HasColumnName("INTERESTGL");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Israte).HasColumnName("ISRATE");

                entity.Property(e => e.Lastupdatedby)
                    .HasColumnName("LASTUPDATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Principalgl).HasColumnName("PRINCIPALGL");

                entity.Property(e => e.Sourcebranchid).HasColumnName("SOURCEBRANCHID");
            });

            modelBuilder.Entity<TblBankingAccumulatedInterest>(entity =>
            {
                entity.ToTable("tbl_BankingAccumulatedInterest", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DDate)
                    .HasColumnName("dDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.LastDefaultDate).HasColumnType("datetime");

                entity.Property(e => e.Productacctno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingAccumulatedInterestHistory>(entity =>
            {
                entity.ToTable("tbl_BankingAccumulatedInterestHistory", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DDate)
                    .HasColumnName("dDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.LastDefaultDate).HasColumnType("datetime");

                entity.Property(e => e.Operation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Productacctno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBankingAdjustedScheduleApproval>(entity =>
            {
                entity.ToTable("tbl_BankingAdjustedScheduleApproval", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdjustedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalRemark).IsUnicode(false);

                entity.Property(e => e.Approvedby)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Customer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdjusted).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.Product)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingAllBanks>(entity =>
            {
                entity.HasKey(e => e.BankId);

                entity.ToTable("tbl_BankingAllBanks", "Credit");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Oldname)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingApprovalTrack>(entity =>
            {
                entity.ToTable("tbl_Banking_ApprovalTrack", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BatchRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Operation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProdNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingApprovalTrack1>(entity =>
            {
                entity.ToTable("tbl_BankingApprovalTrack", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BatchRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Operation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProdNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingCadeposit>(entity =>
            {
                entity.ToTable("TBL_Banking_CADeposit", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ActualDate).HasColumnType("datetime");

                entity.Property(e => e.AmtDeposited).HasColumnType("money");

                entity.Property(e => e.AmtDeposited1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BankLocation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeBank)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DepositorAddr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepositorName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepositorPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepositorSign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationCa).HasColumnName("DestinationCA");

                entity.Property(e => e.FundSource)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IddateExpiry)
                    .HasColumnName("IDDateExpiry")
                    .HasColumnType("date");

                entity.Property(e => e.IddateIssued)
                    .HasColumnName("IDDateIssued")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idno)
                    .HasColumnName("IDNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Idtype)
                    .HasColumnName("IDType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MeansOfPayment)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Miscode)
                    .HasColumnName("MISCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.PrincipalBalGl)
                    .HasColumnName("PrincipalBalGL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SlipNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCa).HasColumnName("SourceCA");

                entity.Property(e => e.TillAcct)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingChangeRepaymentDate>(entity =>
            {
                entity.ToTable("tbl_BankingChangeRepaymentDate", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovalRemark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.NewRepaymentDate)
                    .HasColumnName("newRepaymentDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OldRepaymentDate)
                    .HasColumnName("oldRepaymentDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingChangeSchedule>(entity =>
            {
                entity.ToTable("tbl_BankingChangeSchedule", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovalRemark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.FreqType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewSchedule)
                    .HasColumnName("newSchedule")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldSchedule)
                    .HasColumnName("oldSchedule")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OpId).HasColumnName("OpID");

                entity.Property(e => e.PrincipalFreqType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProdNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Scheduled).HasColumnName("scheduled");
            });

            modelBuilder.Entity<TblBankingCommittee>(entity =>
            {
                entity.ToTable("tbl_BankingCommittee", "GeneralSetup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommitteeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");
            });

            modelBuilder.Entity<TblBankingCotsetup>(entity =>
            {
                entity.ToTable("tbl_BankingCOTsetup", "Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditGl)
                    .HasColumnName("CreditGL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DebitGl)
                    .HasColumnName("DebitGL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FeeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsFeeRate).HasColumnName("isFeeRate");

                entity.Property(e => e.PdId).HasColumnName("pdID");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingCreditArchivedInterest>(entity =>
            {
                entity.ToTable("tbl_BankingCreditArchivedInterest", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBankingCreditArchivedInterestHistory>(entity =>
            {
                entity.ToTable("tbl_BankingCreditArchivedInterestHistory", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateDone).HasColumnType("datetime");

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBankingCreditRepaymentNdmb>(entity =>
            {
                entity.ToTable("tbl_BankingCreditRepaymentNDMB", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BatchRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DatePaid).HasColumnType("datetime");

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingCustomerFees>(entity =>
            {
                entity.ToTable("tbl_BankingCustomerFees", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FeesId).HasColumnName("FeesID");

                entity.Property(e => e.FeesSchedule)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Miscode)
                    .HasColumnName("MISCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Rate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingCustomerSecurity>(entity =>
            {
                entity.ToTable("tbl_BankingCustomerSecurity", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssetDescr).IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessAddress).HasMaxLength(50);

                entity.Property(e => e.CompanyAddress).HasMaxLength(50);

                entity.Property(e => e.ContactPhone).HasMaxLength(50);

                entity.Property(e => e.Counterparty)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DealId)
                    .HasColumnName("DealID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DocInCustody).IsUnicode(false);

                entity.Property(e => e.DurationOfRelationship).HasMaxLength(50);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Fsv).HasColumnName("FSV");

                entity.Property(e => e.GuarantorName).HasMaxLength(50);

                entity.Property(e => e.InsurEffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.Insurance)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceCoverage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceCoy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvestmentOwner).HasMaxLength(50);

                entity.Property(e => e.LegalPerfection)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LienAccountNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaturityDate).HasColumnType("datetime");

                entity.Property(e => e.Miscode)
                    .HasColumnName("MISCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MyPath)
                    .HasColumnName("myPath")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfCompany).HasMaxLength(50);

                entity.Property(e => e.NameOfStockOwner).HasMaxLength(50);

                entity.Property(e => e.Omv).HasColumnName("OMV");

                entity.Property(e => e.PolicyRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RcustCode)
                    .HasColumnName("RCustCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship).HasMaxLength(50);

                entity.Property(e => e.SecType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityId).HasColumnName("SecurityID");

                entity.Property(e => e.SecuritySchedule)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShareCoy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tracking)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValuationDate).HasColumnType("datetime");

                entity.Property(e => e.Valuer)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingDailyInterestAccrued>(entity =>
            {
                entity.ToTable("tbl_BankingDailyInterestAccrued", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DDate)
                    .HasColumnName("dDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DealId1)
                    .IsRequired()
                    .HasColumnName("DealID1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.IAccrualTodate).HasColumnName("iAccrualTodate");

                entity.Property(e => e.IPrincipal)
                    .HasColumnName("iPrincipal")
                    .HasColumnType("money");

                entity.Property(e => e.InterestAmount).HasColumnType("money");

                entity.Property(e => e.InterestRate).HasColumnType("money");

                entity.Property(e => e.Iptdate).HasColumnName("IPTDate");

                entity.Property(e => e.Iptday).HasColumnName("IPTDay");

                entity.Property(e => e.LastEod)
                    .HasColumnName("LastEOD")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoOfDays).HasColumnName("noOfDays");

                entity.Property(e => e.Scheduled).HasColumnName("scheduled");
            });

            modelBuilder.Entity<TblBankingDailyInterestAccruedHistory>(entity =>
            {
                entity.ToTable("tbl_BankingDailyInterestAccruedHistory", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DDate)
                    .HasColumnName("dDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DealId1)
                    .HasColumnName("DealID1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.IAccrualTodate)
                    .HasColumnName("iAccrualTodate")
                    .HasColumnType("money");

                entity.Property(e => e.IPrincipal)
                    .HasColumnName("iPrincipal")
                    .HasColumnType("money");

                entity.Property(e => e.InterestAmount).HasColumnType("money");

                entity.Property(e => e.InterestRate).HasColumnType("money");

                entity.Property(e => e.Iptdate)
                    .HasColumnName("IPTDate")
                    .HasColumnType("money");

                entity.Property(e => e.Iptday)
                    .HasColumnName("IPTDay")
                    .HasColumnType("money");

                entity.Property(e => e.LastEod)
                    .HasColumnName("LastEOD")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoOfDays).HasColumnName("noOfDays");

                entity.Property(e => e.Scheduled).HasColumnName("scheduled");

                entity.Property(e => e.TransDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBankingInterestSuspension>(entity =>
            {
                entity.ToTable("tbl_BankingInterestSuspension", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("date");

                entity.Property(e => e.DatePaid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateSuspended).HasColumnType("datetime");

                entity.Property(e => e.Interest)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastIntPaid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrincipalPaid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MisCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Principal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingLoanApplication>(entity =>
            {
                entity.ToTable("tbl_BankingLoanApplication", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ApprovalComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentAcct)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DatePaid).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.FeeCharge).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FirstpayDate).HasColumnType("datetime");

                entity.Property(e => e.FreqType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Miscode)
                    .HasColumnName("MISCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PdTypeId).HasColumnName("pdTypeID");

                entity.Property(e => e.PrincipalFreqType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipManager)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipManagerDept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipOfficer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipOfficerDept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.UpfrontInterest).HasColumnName("upfrontInterest");

                entity.Property(e => e.Upfrontprincipal).HasColumnName("upfrontprincipal");
            });

            modelBuilder.Entity<TblBankingLoanCancelation>(entity =>
            {
                entity.ToTable("tbl_BankingLoanCancelation", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved)
                    .HasColumnName("dateApproved")
                    .HasColumnType("date");

                entity.Property(e => e.DateCancelled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastInterestPaid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrincipalPaid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MisCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Principal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RealReason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RealReasonId)
                    .HasColumnName("RealReasonID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingLoanChecklist>(entity =>
            {
                entity.ToTable("tbl_BankingLoanChecklist", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Checklist).IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ddate)
                    .HasColumnName("DDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingLoanLease>(entity =>
            {
                entity.ToTable("tbl_BankingLoanLease", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovalComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveMaintainComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveOpComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BulletFreqName)
                    .HasColumnName("BulletFReqName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BulletName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditMandate).IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentAcct)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateOfDisburse).HasColumnType("datetime");

                entity.Property(e => e.DatePaid).HasColumnType("datetime");

                entity.Property(e => e.DisburseComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Disburser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.FirstpayDate).HasColumnType("datetime");

                entity.Property(e => e.FreqType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IssueOfferletter).HasColumnName("issueOfferletter");

                entity.Property(e => e.Miscode)
                    .HasColumnName("MISCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MyPath)
                    .HasColumnName("myPath")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nhf).HasColumnName("NHF");

                entity.Property(e => e.NoOfPrincipalAddition).HasColumnName("noOfPrincipalAddition");

                entity.Property(e => e.NoOfPrincipalReduction).HasColumnName("noOfPrincipalReduction");

                entity.Property(e => e.Officer1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Officer2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OpeningComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Pccode1)
                    .HasColumnName("PCcode1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pccode2)
                    .HasColumnName("PCcode2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PdTypeId).HasColumnName("pdTypeID");

                entity.Property(e => e.PrincipalFreqType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileLoan).HasColumnName("profileLoan");

                entity.Property(e => e.Ref)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipManager)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipManagerDept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipOfficer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipOfficerDept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Riskass).HasColumnName("riskass");

                entity.Property(e => e.Sbumis)
                    .HasColumnName("SBUMIS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.UpfrontInterest).HasColumnName("upfrontInterest");

                entity.Property(e => e.Upfrontprincipal).HasColumnName("upfrontprincipal");

                entity.Property(e => e.Upload).IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingLoanWalkOut>(entity =>
            {
                entity.ToTable("tbl_BankingLoanWalkOut", "Credit");

                entity.Property(e => e.Approvedby)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LoanWalkOut).HasColumnType("money");

                entity.Property(e => e.MisCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldRate).HasColumnName("oldRate");

                entity.Property(e => e.OldTenor).HasColumnName("oldTenor");

                entity.Property(e => e.ProductAccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBankingOperationSetup>(entity =>
            {
                entity.ToTable("tbl_BankingOperationSetup", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Operation)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingoperationtype>(entity =>
            {
                entity.ToTable("TBL_BANKINGOPERATIONTYPE", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingOperativeAccounts>(entity =>
            {
                entity.ToTable("tbl_BankingOperativeAccounts", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AprovalRemark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChangedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.NewAccountId)
                    .HasColumnName("newAccountID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewAmount).HasColumnName("newAmount");

                entity.Property(e => e.NewOperativeAccount)
                    .HasColumnName("newOperativeAccount")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldOperativeAccount)
                    .HasColumnName("oldOperativeAccount")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.ProductAccountNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingPrincipalAddition>(entity =>
            {
                entity.ToTable("tbl_BankingPrincipalAddition", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovalRemark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BatchRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.NewPrincipal).HasColumnName("newPrincipal");

                entity.Property(e => e.OldPrincipal).HasColumnName("oldPrincipal");

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.PrincipalFreqType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingPrincipalReduction>(entity =>
            {
                entity.ToTable("tbl_BankingPrincipalReduction", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalRemark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BatchRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.InterestStatus).HasColumnName("interestStatus");

                entity.Property(e => e.NewPrincipal).HasColumnName("newPrincipal");

                entity.Property(e => e.OldPrincipal).HasColumnName("oldPrincipal");

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.PrincipalFreqType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingProduct>(entity =>
            {
                entity.ToTable("tbl_BankingProduct", "Product");

                entity.Property(e => e.Act)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealClassification)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InterestsBs)
                    .HasColumnName("InterestsBS")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OldpdCode)
                    .HasColumnName("oldpdCode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PdApplyWht).HasColumnName("pdApplyWHT");

                entity.Property(e => e.PdApproved).HasColumnName("pdApproved");

                entity.Property(e => e.PdBondDiscount)
                    .HasColumnName("pdBondDiscount")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PdBondGl)
                    .HasColumnName("pdBondGL")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PdBondPremium)
                    .HasColumnName("pdBondPremium")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PdCategoryId).HasColumnName("pdCategoryID");

                entity.Property(e => e.PdCode)
                    .HasColumnName("pdCode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PdCompleted).HasColumnName("pdCompleted");

                entity.Property(e => e.PdDescription)
                    .HasColumnName("pdDescription")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PdDormantGl)
                    .HasColumnName("pdDormantGL")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PdId).HasColumnName("pdID");

                entity.Property(e => e.PdInterestGl)
                    .HasColumnName("pdInterestGL")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PdInterestRvGl)
                    .HasColumnName("pdInterestRvGL")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PdMadeby)
                    .IsRequired()
                    .HasColumnName("pdMadeby")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PdMaxRate)
                    .HasColumnName("pdMaxRate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PdMaxTenor)
                    .HasColumnName("pdMaxTenor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PdMinRate)
                    .HasColumnName("pdMinRate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PdMinTenor)
                    .HasColumnName("pdMinTenor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PdMinimumBalance)
                    .HasColumnName("pdMinimumBalance")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PdMmtype)
                    .HasColumnName("pdMMType")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PdMoratorium).HasColumnName("pdMoratorium");

                entity.Property(e => e.PdName)
                    .IsRequired()
                    .HasColumnName("pdName")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PdOpeningBalance)
                    .HasColumnName("pdOpeningBalance")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PdOverdraft).HasColumnName("pdOverdraft");

                entity.Property(e => e.PdPrincipalBalanceGl)
                    .HasColumnName("pdPrincipalBalanceGL")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PdStep).HasColumnName("pdStep");

                entity.Property(e => e.PdTypeId).HasColumnName("pdTypeID");

                entity.Property(e => e.Remit).HasColumnName("remit");

                entity.Property(e => e.SettlementDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TreasuryBillType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblBankingProductAccountCriteria>(entity =>
            {
                entity.ToTable("tbl_BankingProductAccountCriteria", "Product");

                entity.Property(e => e.PdId).HasColumnName("pdID");
            });

            modelBuilder.Entity<TblBankingProductFees>(entity =>
            {
                entity.HasKey(e => e.PdFeesId);

                entity.ToTable("tbl_BankingProductFees", "Product");

                entity.Property(e => e.PdFeesId).HasColumnName("pdFeesID");

                entity.Property(e => e.Catid).HasColumnName("catid");

                entity.Property(e => e.PdFeedate)
                    .HasColumnName("pdFeedate")
                    .HasColumnType("date");

                entity.Property(e => e.PdFeesInterval)
                    .IsRequired()
                    .HasColumnName("pdFeesInterval")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PdFeesLedgerCr)
                    .HasColumnName("pdFeesLedgerCR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PdFeesLedgerDr)
                    .IsRequired()
                    .HasColumnName("pdFeesLedgerDR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PdFeesName)
                    .IsRequired()
                    .HasColumnName("pdFeesName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PdFixed).HasColumnName("pdFixed");

                entity.Property(e => e.PdRate).HasColumnName("pdRate");

                entity.Property(e => e.PdTarget).HasColumnName("pdTarget");

                entity.Property(e => e.PdTypeId).HasColumnName("pdTypeID");

                entity.Property(e => e.Subcat)
                    .HasColumnName("subcat")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubcatId).HasColumnName("subcatID");
            });

            modelBuilder.Entity<TblBankingProductFeesList>(entity =>
            {
                entity.ToTable("tbl_BankingProductFeesList", "Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PdFeesId).HasColumnName("pdFeesID");

                entity.Property(e => e.PdFeesName)
                    .HasColumnName("pdFeesName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PdId).HasColumnName("pdID");

                entity.Property(e => e.PdRate).HasColumnName("pdRate");
            });

            modelBuilder.Entity<TblBankingProductFeesListLoanMapping>(entity =>
            {
                entity.ToTable("tbl_BankingProductFeesListLoanMapping", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeesId).HasColumnName("FeesID");

                entity.Property(e => e.FeesName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Rate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingProductSecurity>(entity =>
            {
                entity.HasKey(e => e.PdSecId);

                entity.ToTable("tbl_BankingProductSecurity", "Product");

                entity.Property(e => e.PdSecId).HasColumnName("pdSecID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.PdCode)
                    .HasColumnName("pdCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PdSecurity)
                    .HasColumnName("pdSecurity")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SecType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingProductSecurityList>(entity =>
            {
                entity.ToTable("tbl_BankingProductSecurityList", "Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PdId).HasColumnName("pdID");

                entity.Property(e => e.PdSecId).HasColumnName("pdSecID");
            });

            modelBuilder.Entity<TblBankingProductType>(entity =>
            {
                entity.HasKey(e => e.PdTypeId);

                entity.ToTable("tbl_BankingProductType", "Product");

                entity.Property(e => e.PdTypeId).HasColumnName("pdTypeID");

                entity.Property(e => e.PdGroupId).HasColumnName("pdGroupID");

                entity.Property(e => e.PdPayDay).HasColumnName("pdPayDay");

                entity.Property(e => e.PdType)
                    .IsRequired()
                    .HasColumnName("pdType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingRestructure>(entity =>
            {
                entity.ToTable("tbl_BankingRestructure", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FreqType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrincipalPaid).HasColumnType("money");

                entity.Property(e => e.MisCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewTenor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewTerminateDate)
                    .HasColumnName("newTerminateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OldRate).HasColumnName("oldRate");

                entity.Property(e => e.PreviousTenor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Principal).HasColumnType("money");

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RestructureDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBankingReviseRate>(entity =>
            {
                entity.ToTable("tbl_bankingReviseRate", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.LastInterestPaid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrincipalpaid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MisCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingSecurityWorth>(entity =>
            {
                entity.ToTable("tbl_BankingSecurityWorth", "Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovalComment).IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.SecId)
                    .HasColumnName("SecID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Upload).IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingsinglefundtransfer>(entity =>
            {
                entity.ToTable("TBL_BANKINGSINGLEFUNDTRANSFER", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountCr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountDr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AppSource).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.NarrationCr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NarrationDr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostingTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TransCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBankingSuspenseAccount>(entity =>
            {
                entity.ToTable("tbl_BankingSuspenseAccount", "Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PenalCharge).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Wht)
                    .HasColumnName("WHT")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblBankingTermination>(entity =>
            {
                entity.ToTable("tbl_BankingTermination", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved)
                    .HasColumnName("dateApproved")
                    .HasColumnType("date");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateTerminated).HasColumnType("datetime");

                entity.Property(e => e.MisCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingTillfunction>(entity =>
            {
                entity.ToTable("TBL_BANKING_TILLFUNCTION", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.TillFunction)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBranch>(entity =>
            {
                entity.HasKey(e => e.Branchid);

                entity.ToTable("TBL_BRANCH", "Customer");

                entity.HasIndex(e => e.Branchcode)
                    .HasName("UQ__tbl_Bran__1C61B888B5F4E4F1")
                    .IsUnique();

                entity.HasIndex(e => e.Branchname)
                    .HasName("UQ__tbl_Bran__3903DB036F659E7B")
                    .IsUnique();

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Addressline1)
                    .HasColumnName("ADDRESSLINE1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Addressline2)
                    .HasColumnName("ADDRESSLINE2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Branchcode)
                    .IsRequired()
                    .HasColumnName("BRANCHCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasColumnName("BRANCHNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cityid).HasColumnName("CITYID");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(2000);

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.Lastupdatedby).HasColumnName("LASTUPDATEDBY");

                entity.Property(e => e.Lgaid).HasColumnName("LGAID");

                entity.Property(e => e.NplLimitexceeded).HasColumnName("NPL_LIMITEXCEEDED");

                entity.Property(e => e.Stateid).HasColumnName("STATEID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblBranch)
                    .HasForeignKey(d => d.Cityid)
                    .HasConstraintName("FK_tbl_Branch_tbl_City");

                entity.HasOne(d => d.Lga)
                    .WithMany(p => p.TblBranch)
                    .HasForeignKey(d => d.Lgaid)
                    .HasConstraintName("FK_TBL_BRANCH_TBL_STATE_AND_LGA");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblBranch)
                    .HasForeignKey(d => d.Stateid)
                    .HasConstraintName("FK_tbl_Branch_tbl_State");
            });

            modelBuilder.Entity<TblBusinesscategory>(entity =>
            {
                entity.ToTable("TBL_BUSINESSCATEGORY", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCasa>(entity =>
            {
                entity.HasKey(e => e.Casaaccountid);

                entity.ToTable("TBL_CASA", "Customer");

                entity.HasIndex(e => e.Accountnumber)
                    .HasName("IX_TBL_CASA")
                    .IsUnique();

                entity.Property(e => e.Casaaccountid).HasColumnName("CASAACCOUNTID");

                entity.Property(e => e.Accountname)
                    .IsRequired()
                    .HasColumnName("ACCOUNTNAME")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Accountnumber)
                    .IsRequired()
                    .HasColumnName("ACCOUNTNUMBER")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Accountofficerdeptid).HasColumnName("ACCOUNTOFFICERDEPTID");

                entity.Property(e => e.Accountofficerid)
                    .HasColumnName("ACCOUNTOFFICERID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Accountstatusid)
                    .HasColumnName("ACCOUNTSTATUSID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Actionby)
                    .HasColumnName("ACTIONBY")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Actiondate)
                    .HasColumnName("ACTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Approvalstatusid).HasColumnName("APPROVALSTATUSID");

                entity.Property(e => e.Availablebalance)
                    .HasColumnName("AVAILABLEBALANCE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Currencyid)
                    .HasColumnName("CURRENCYID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Effectivedate)
                    .HasColumnName("EFFECTIVEDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Hasoverdraft).HasColumnName("HASOVERDRAFT");

                entity.Property(e => e.Interestrate)
                    .HasColumnName("INTERESTRATE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Iscurrentaccount).HasColumnName("ISCURRENTACCOUNT");

                entity.Property(e => e.Lastupdatecomment)
                    .HasColumnName("LASTUPDATECOMMENT")
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdatedby)
                    .HasColumnName("LASTUPDATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ledgerbalance)
                    .HasColumnName("LEDGERBALANCE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mandate)
                    .HasColumnName("MANDATE")
                    .IsUnicode(false);

                entity.Property(e => e.Miscode)
                    .HasColumnName("MISCODE")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Oldproductaccountnumber1)
                    .HasColumnName("OLDPRODUCTACCOUNTNUMBER1")
                    .HasMaxLength(50);

                entity.Property(e => e.Oldproductaccountnumber2)
                    .HasColumnName("OLDPRODUCTACCOUNTNUMBER2")
                    .HasMaxLength(50);

                entity.Property(e => e.Oldproductaccountnumber3)
                    .HasColumnName("OLDPRODUCTACCOUNTNUMBER3")
                    .HasMaxLength(50);

                entity.Property(e => e.Operationid).HasColumnName("OPERATIONID");

                entity.Property(e => e.Overdraftamount)
                    .HasColumnName("OVERDRAFTAMOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Overdraftexpirydate)
                    .HasColumnName("OVERDRAFTEXPIRYDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Overdraftinterestrate)
                    .HasColumnName("OVERDRAFTINTERESTRATE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Postnostatusid).HasColumnName("POSTNOSTATUSID");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Relationshipmanagerid)
                    .HasColumnName("RELATIONSHIPMANAGERID")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Relationshipofficerdeptid).HasColumnName("RELATIONSHIPOFFICERDEPTID");

                entity.Property(e => e.Relationshipofficerid)
                    .HasColumnName("RELATIONSHIPOFFICERID")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Teammiscode)
                    .HasColumnName("TEAMMISCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tenor)
                    .HasColumnName("TENOR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Terminaldate)
                    .HasColumnName("TERMINALDATE")
                    .HasColumnType("date");

                entity.HasOne(d => d.Accountstatus)
                    .WithMany(p => p.TblCasa)
                    .HasForeignKey(d => d.Accountstatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CASA_TBL_CASAACCOUNTSTATUS");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCasa)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CASA_tbl_Customer");
            });

            modelBuilder.Entity<TblCasaaccountstatus>(entity =>
            {
                entity.HasKey(e => e.Accountstatusid);

                entity.ToTable("TBL_CASAACCOUNTSTATUS", "Customer");

                entity.Property(e => e.Accountstatusid).HasColumnName("ACCOUNTSTATUSID");

                entity.Property(e => e.Accountstatusname)
                    .IsRequired()
                    .HasColumnName("ACCOUNTSTATUSNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCasafreeze>(entity =>
            {
                entity.ToTable("TBL_CASAFREEZE", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountname)
                    .HasColumnName("ACCOUNTNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Approved).HasColumnName("APPROVED");

                entity.Property(e => e.Approvedby)
                    .HasColumnName("APPROVEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Attacheddocumentid).HasColumnName("ATTACHEDDOCUMENTID");

                entity.Property(e => e.Balance).HasColumnName("BALANCE");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Customerbranch)
                    .HasColumnName("CUSTOMERBRANCH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customercode)
                    .HasColumnName("CUSTOMERCODE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateapproved)
                    .HasColumnName("DATEAPPROVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Destinationca).HasColumnName("DESTINATIONCA");

                entity.Property(e => e.Disapproved).HasColumnName("DISAPPROVED");

                entity.Property(e => e.Freezeamount).HasColumnName("FREEZEAMOUNT");

                entity.Property(e => e.Isreversed).HasColumnName("ISREVERSED");

                entity.Property(e => e.Miscode)
                    .HasColumnName("MISCODE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasColumnName("NARRATION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Operationid).HasColumnName("OPERATIONID");

                entity.Property(e => e.Principalbalancegl)
                    .HasColumnName("PRINCIPALBALANCEGL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Productaccountno)
                    .HasColumnName("PRODUCTACCOUNTNO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sourceca).HasColumnName("SOURCECA");

                entity.Property(e => e.Tillaccount)
                    .HasColumnName("TILLACCOUNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transactiontime)
                    .HasColumnName("TRANSACTIONTIME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCasapostnostatus>(entity =>
            {
                entity.HasKey(e => e.Postnostatusid);

                entity.ToTable("TBL_CASAPOSTNOSTATUS", "Customer");

                entity.Property(e => e.Postnostatusid).HasColumnName("POSTNOSTATUSID");

                entity.Property(e => e.Postnostatusname)
                    .IsRequired()
                    .HasColumnName("POSTNOSTATUSNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCasaTest>(entity =>
            {
                entity.ToTable("TBL_CASA_TEST", "Customer");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblChequebookdetail>(entity =>
            {
                entity.ToTable("TBL_CHEQUEBOOKDETAIL", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .IsRequired()
                    .HasColumnName("ACCOUNTNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charge).HasColumnName("CHARGE");

                entity.Property(e => e.Chequebooktypeid).HasColumnName("CHEQUEBOOKTYPEID");

                entity.Property(e => e.Dateapproved)
                    .HasColumnName("DATEAPPROVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Endrange).HasColumnName("ENDRANGE");

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Ischarged).HasColumnName("ISCHARGED");

                entity.Property(e => e.Iscountercheque).HasColumnName("ISCOUNTERCHEQUE");

                entity.Property(e => e.Leavesno).HasColumnName("LEAVESNO");

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .IsUnicode(false);

                entity.Property(e => e.Startrange).HasColumnName("STARTRANGE");

                entity.HasOne(d => d.Chequebooktype)
                    .WithMany(p => p.TblChequebookdetail)
                    .HasForeignKey(d => d.Chequebooktypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CHEQUEBOOKDETAIL_TBL_CHEQUEBOOKTYPE");
            });

            modelBuilder.Entity<TblChequebooktype>(entity =>
            {
                entity.ToTable("TBL_CHEQUEBOOKTYPE", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Charge)
                    .HasColumnName("CHARGE")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Chequetype)
                    .IsRequired()
                    .HasColumnName("CHEQUETYPE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Creditledger)
                    .HasColumnName("CREDITLEDGER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Leavesno).HasColumnName("LEAVESNO");

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblChequecharges>(entity =>
            {
                entity.ToTable("TBL_CHEQUECHARGES", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountledgerid).HasColumnName("ACCOUNTLEDGERID");

                entity.Property(e => e.Branchcode)
                    .HasColumnName("BRANCHCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Companycode)
                    .HasColumnName("COMPANYCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateupdated)
                    .HasColumnName("DATEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isdiscountcharge).HasColumnName("ISDISCOUNTCHARGE");

                entity.Property(e => e.Isreturncharge).HasColumnName("ISRETURNCHARGE");

                entity.Property(e => e.Maxamount).HasColumnName("MAXAMOUNT");

                entity.Property(e => e.Percentage)
                    .HasColumnName("PERCENTAGE")
                    .HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<TblChequeleafstatus>(entity =>
            {
                entity.ToTable("TBL_CHEQUELEAFSTATUS", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblChequeleavesdetail>(entity =>
            {
                entity.ToTable("TBL_CHEQUELEAVESDETAIL", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Chequebookid).HasColumnName("CHEQUEBOOKID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateupdated)
                    .HasColumnName("DATEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Leafno).HasColumnName("LEAFNO");

                entity.Property(e => e.Leafstatus).HasColumnName("LEAFSTATUS");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("UPDATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Chequebook)
                    .WithMany(p => p.TblChequeleavesdetail)
                    .HasForeignKey(d => d.Chequebookid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CHEQUELEAVESDETAIL_TBL_CHEQUEBOOKDETAIL");

                entity.HasOne(d => d.LeafstatusNavigation)
                    .WithMany(p => p.TblChequeleavesdetail)
                    .HasForeignKey(d => d.Leafstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CHEQUELEAVESDETAIL_TBL_CHEQUELEAFSTATUS");
            });

            modelBuilder.Entity<TblCity>(entity =>
            {
                entity.HasKey(e => e.Cityid);

                entity.ToTable("TBL_CITY", "Customer");

                entity.HasIndex(e => e.Cityname)
                    .HasName("IX_tbl_Cities")
                    .IsUnique();

                entity.Property(e => e.Cityid).HasColumnName("CITYID");

                entity.Property(e => e.Allowedforcollateral).HasColumnName("ALLOWEDFORCOLLATERAL");

                entity.Property(e => e.Cityclassid).HasColumnName("CITYCLASSID");

                entity.Property(e => e.Cityname)
                    .IsRequired()
                    .HasColumnName("CITYNAME")
                    .HasMaxLength(150);

                entity.Property(e => e.Stateid).HasColumnName("STATEID");
            });

            modelBuilder.Entity<TblClearingoptions>(entity =>
            {
                entity.ToTable("TBL_CLEARINGOPTIONS", "Retail");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCompany>(entity =>
            {
                entity.HasKey(e => e.Companyid);

                entity.ToTable("TBL_COMPANY", "Customer");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__tbl_Comp__737584F670C88042")
                    .IsUnique();

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Accountingstandardid).HasColumnName("ACCOUNTINGSTANDARDID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(250);

                entity.Property(e => e.Authorisedsharecapital)
                    .HasColumnName("AUTHORISEDSHARECAPITAL")
                    .HasColumnType("money");

                entity.Property(e => e.Companyclassid).HasColumnName("COMPANYCLASSID");

                entity.Property(e => e.Companylogo).HasColumnName("COMPANYLOGO");

                entity.Property(e => e.Companytypeid).HasColumnName("COMPANYTYPEID");

                entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Currencyid).HasColumnName("CURRENCYID");

                entity.Property(e => e.Dateofcommencement)
                    .HasColumnName("DATEOFCOMMENCEMENT")
                    .HasColumnType("date");

                entity.Property(e => e.Dateofincorporation)
                    .HasColumnName("DATEOFINCORPORATION")
                    .HasColumnType("date");

                entity.Property(e => e.Dateofrenewalofregistration)
                    .HasColumnName("DATEOFRENEWALOFREGISTRATION")
                    .HasColumnType("date");

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ebusinesscode)
                    .HasColumnName("EBUSINESSCODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100);

                entity.Property(e => e.Eoyprofitandlossgl)
                    .HasColumnName("EOYPROFITANDLOSSGL")
                    .HasMaxLength(50);

                entity.Property(e => e.Formermanagerstrustees)
                    .HasColumnName("FORMERMANAGERSTRUSTEES")
                    .HasMaxLength(50);

                entity.Property(e => e.Functionsregistered)
                    .HasColumnName("FUNCTIONSREGISTERED")
                    .HasMaxLength(50);

                entity.Property(e => e.Initialfloatation).HasColumnName("INITIALFLOATATION");

                entity.Property(e => e.Initialsubscription).HasColumnName("INITIALSUBSCRIPTION");

                entity.Property(e => e.Investmentobjective)
                    .HasColumnName("INVESTMENTOBJECTIVE")
                    .HasMaxLength(1000);

                entity.Property(e => e.Lastupdatedby).HasColumnName("LASTUPDATEDBY");

                entity.Property(e => e.Logopath)
                    .HasColumnName("LOGOPATH")
                    .HasMaxLength(100);

                entity.Property(e => e.Managementtypeid).HasColumnName("MANAGEMENTTYPEID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(250);

                entity.Property(e => e.Nameofregistrar)
                    .HasColumnName("NAMEOFREGISTRAR")
                    .HasMaxLength(100);

                entity.Property(e => e.Nameofscheme)
                    .HasColumnName("NAMEOFSCHEME")
                    .HasMaxLength(50);

                entity.Property(e => e.Nameoftrustees)
                    .HasColumnName("NAMEOFTRUSTEES")
                    .HasMaxLength(100);

                entity.Property(e => e.Natureofbusinessid).HasColumnName("NATUREOFBUSINESSID");

                entity.Property(e => e.Parentid).HasColumnName("PARENTID");

                entity.Property(e => e.PreliminaryevaluationLimit)
                    .HasColumnName("PRELIMINARYEVALUATION_LIMIT")
                    .HasColumnType("money");

                entity.Property(e => e.Registeredby)
                    .HasColumnName("REGISTEREDBY")
                    .HasMaxLength(100);

                entity.Property(e => e.Shareholdersfund)
                    .HasColumnName("SHAREHOLDERSFUND")
                    .HasColumnType("money");

                entity.Property(e => e.Telephone)
                    .HasColumnName("TELEPHONE")
                    .HasMaxLength(100);

                entity.Property(e => e.Trusteesaddress)
                    .HasColumnName("TRUSTEESADDRESS")
                    .HasMaxLength(1000);

                entity.Property(e => e.Website)
                    .HasColumnName("WEBSITE")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Companyclass)
                    .WithMany(p => p.TblCompany)
                    .HasForeignKey(d => d.Companyclassid)
                    .HasConstraintName("FK__tbl_Compa__Compa__286302EC");

                entity.HasOne(d => d.Companytype)
                    .WithMany(p => p.TblCompany)
                    .HasForeignKey(d => d.Companytypeid)
                    .HasConstraintName("FK__tbl_Compa__Compa__29572725");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblCompany)
                    .HasForeignKey(d => d.Countryid)
                    .HasConstraintName("FK__tbl_Compa__Count__276EDEB3");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblCompany)
                    .HasForeignKey(d => d.Currencyid)
                    .HasConstraintName("FK_tbl_Company_tbl_Currency");

                entity.HasOne(d => d.Natureofbusiness)
                    .WithMany(p => p.TblCompany)
                    .HasForeignKey(d => d.Natureofbusinessid)
                    .HasConstraintName("FK__tbl_Compa__Natur__267ABA7A");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.Parentid)
                    .HasConstraintName("FK_tbl_Company_tbl_Company");
            });

            modelBuilder.Entity<TblCompanyclass>(entity =>
            {
                entity.HasKey(e => e.Companyclassid);

                entity.ToTable("TBL_COMPANYCLASS", "Customer");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__TBL_COMP__D9C1FA00AD730556")
                    .IsUnique();

                entity.Property(e => e.Companyclassid).HasColumnName("COMPANYCLASSID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblCompanytype>(entity =>
            {
                entity.HasKey(e => e.Companytypeid);

                entity.ToTable("TBL_COMPANYTYPE", "Customer");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__TBL_COMP__D9C1FA00C5149EEC")
                    .IsUnique();

                entity.Property(e => e.Companytypeid).HasColumnName("COMPANYTYPEID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblCotsetup>(entity =>
            {
                entity.ToTable("TBL_COTSETUP", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLedgerId).HasColumnName("CreditLedgerID");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FeeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Maintenance')");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.HasKey(e => e.Countryid);

                entity.ToTable("TBL_COUNTRY", "Customer");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__tbl_Coun__737584F6A66ACCD7")
                    .IsUnique();

                entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");

                entity.Property(e => e.Countrycode)
                    .HasColumnName("COUNTRYCODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblCreditAppraisalAttachment>(entity =>
            {
                entity.HasKey(e => e.AppraisalAttachmentId);

                entity.ToTable("tbl_CreditAppraisalAttachment", "Credit");

                entity.Property(e => e.AppraisalAttachmentId).ValueGeneratedNever();

                entity.Property(e => e.AppraisalAttachmentImage)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.AppraisalAttachmentPath)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AppraisalAttachmentRemark).IsUnicode(false);

                entity.Property(e => e.AppraisalAttachmentTitle)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AttachedBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AttachedDate)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAccountNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAppraisalGrade>(entity =>
            {
                entity.HasKey(e => e.CreditGradeId);

                entity.ToTable("tbl_CreditAppraisalGrade", "Credit");

                entity.Property(e => e.CreditGradeId).HasColumnName("CreditGradeID");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyId)
                    .HasColumnName("CoyID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditGrade)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCreditAppraisalGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("tbl_CreditAppraisalGroup", "Credit");

                entity.HasIndex(e => e.GroupName)
                    .HasName("UC_tbl_CreditAppraisalGroup_GroupName")
                    .IsUnique();

                entity.Property(e => e.BranchId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CoyId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCreditAppraisalGroupProfile>(entity =>
            {
                entity.HasKey(e => e.GroupProfileId);

                entity.ToTable("tbl_CreditAppraisalGroupProfile", "Credit");

                entity.HasIndex(e => new { e.GroupId, e.ProfileId })
                    .HasName("UC_tbl_CreditAppraisalGroupProfile_GroupIdProfileId")
                    .IsUnique();

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.ProfileName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblCreditAppraisalLevel>(entity =>
            {
                entity.HasKey(e => e.LevelId);

                entity.ToTable("tbl_CreditAppraisalLevel", "Credit");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CoyId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.LevelName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAppraisalLevelProfile>(entity =>
            {
                entity.HasKey(e => e.LevelProfileId);

                entity.ToTable("tbl_CreditAppraisalLevelProfile", "Credit");
            });

            modelBuilder.Entity<TblCreditAppraisalMemorandum>(entity =>
            {
                entity.HasKey(e => e.MemoId);

                entity.ToTable("tbl_CreditAppraisalMemorandum", "Credit");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memorandum).IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAppraisalMemorandumTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("tbl_CreditAppraisalMemorandumTemplate", "Credit");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memorandum).IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TemplatePath)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAppraisalOfficers>(entity =>
            {
                entity.ToTable("tbl_CreditAppraisalOfficers", "Credit");

                entity.HasIndex(e => e.UserName)
                    .HasName("UC_tbl_CreditAppraisalOfficers_UserName")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CoyId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAppraisalOfficersId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastModified).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName).HasMaxLength(100);

                entity.Property(e => e.UnitId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAppraisalPhase>(entity =>
            {
                entity.HasKey(e => e.PhaseId);

                entity.ToTable("tbl_CreditAppraisalPhase", "Credit");

                entity.Property(e => e.Phase)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAppraisalProduct>(entity =>
            {
                entity.HasKey(e => e.ProductCode);

                entity.ToTable("tbl_CreditAppraisalProduct", "Credit");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CoyId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAppraisalProfile>(entity =>
            {
                entity.HasKey(e => e.ProfileId);

                entity.ToTable("tbl_CreditAppraisalProfile", "Credit");

                entity.Property(e => e.Profile)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileDescription).IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAppraisalStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("tbl_CreditAppraisalStatus", "Credit");

                entity.Property(e => e.StatusId).ValueGeneratedNever();

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAccountNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateUpdated)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MadeBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeUpdated)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAppraisalStatusDescription>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("tbl_CreditAppraisalStatusDescription", "Credit");

                entity.Property(e => e.StatusId).ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDescription).IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAppraisalUserGroupMapping>(entity =>
            {
                entity.HasKey(e => e.UserGroupId);

                entity.ToTable("tbl_CreditAppraisalUserGroupMapping", "Credit");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CoyId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAppraisalUserLevelMapping>(entity =>
            {
                entity.HasKey(e => e.LevelUserId);

                entity.ToTable("tbl_CreditAppraisalUserLevelMapping", "Credit");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CoyId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.LevelName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAppraisalUserProfile>(entity =>
            {
                entity.HasKey(e => e.UserProfileId);

                entity.ToTable("tbl_CreditAppraisalUserProfile", "Credit");

                entity.HasIndex(e => new { e.UserId, e.ProfileId })
                    .HasName("UC_tbl_CreditAppraisalUserProfile_UserIdProfileId")
                    .IsUnique();

                entity.Property(e => e.ProfileName).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblCreditAssessmentFactorIndex>(entity =>
            {
                entity.HasKey(e => e.FactorIndexId);

                entity.ToTable("tbl_CreditAssessmentFactorIndex", "Credit");

                entity.Property(e => e.FactorIndexId).HasColumnName("FactorIndexID");

                entity.Property(e => e.FactorIndexDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiskFactorId).HasColumnName("RiskFactorID");
            });

            modelBuilder.Entity<TblCreditAssessmentIndex>(entity =>
            {
                entity.HasKey(e => e.IndexId);

                entity.ToTable("tbl_CreditAssessmentIndex", "Credit");

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.AssessmentIndex)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IndexTitleId).HasColumnName("IndexTitleID");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAssessmentIndexTitle>(entity =>
            {
                entity.HasKey(e => e.IndexTitleId);

                entity.ToTable("tbl_CreditAssessmentIndexTitle", "Credit");

                entity.Property(e => e.IndexTitleId).HasColumnName("IndexTitleID");

                entity.Property(e => e.FactorIndexId).HasColumnName("FactorIndexID");

                entity.Property(e => e.IndexTitleDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAssessmentRiskFactor>(entity =>
            {
                entity.HasKey(e => e.RiskFactorId);

                entity.ToTable("tbl_CreditAssessmentRiskFactor", "Credit");

                entity.Property(e => e.RiskFactorId).HasColumnName("RiskFactorID");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyId)
                    .HasColumnName("CoyID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiskFactorsDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAssessmentRiskRating>(entity =>
            {
                entity.HasKey(e => e.RiskRatingId);

                entity.ToTable("tbl_CreditAssessmentRiskRating", "Credit");

                entity.Property(e => e.BrCode)
                    .HasColumnName("brCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasColumnName("coyCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditGradeDefinitions).IsUnicode(false);

                entity.Property(e => e.CreditGradeDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditGrades)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTypeId).HasColumnName("CreditTypeID");

                entity.Property(e => e.InterestRate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PdCode)
                    .HasColumnName("pdCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiskRating)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiskRatingRemarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCreditAssessmentRiskRatingResult>(entity =>
            {
                entity.HasKey(e => e.ResultId);

                entity.ToTable("tbl_CreditAssessmentRiskRatingResult", "Credit");

                entity.Property(e => e.DateofRating).HasColumnType("datetime");

                entity.Property(e => e.LoanNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ratedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Score).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblCurrency>(entity =>
            {
                entity.HasKey(e => e.Currencyid);

                entity.ToTable("TBL_CURRENCY", "Customer");

                entity.HasIndex(e => e.Currencycode)
                    .HasName("UQ__tbl_Curr__408426BF1B8EB305")
                    .IsUnique();

                entity.HasIndex(e => e.Currencyname)
                    .HasName("UQ__tbl_Curr__3D13D298E6790673")
                    .IsUnique();

                entity.Property(e => e.Currencyid).HasColumnName("CURRENCYID");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Currencycode)
                    .IsRequired()
                    .HasColumnName("CURRENCYCODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Currencyname)
                    .IsRequired()
                    .HasColumnName("CURRENCYNAME")
                    .HasMaxLength(250);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Inuse).HasColumnName("INUSE");

                entity.Property(e => e.Lastupdatedby).HasColumnName("LASTUPDATEDBY");
            });

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.HasKey(e => e.Customerid);

                entity.ToTable("TBL_CUSTOMER", "Customer");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Accountcreationcomplete).HasColumnName("ACCOUNTCREATIONCOMPLETE");

                entity.Property(e => e.Actedonby)
                    .HasColumnName("ACTEDONBY")
                    .HasMaxLength(150);

                entity.Property(e => e.Annualincomeid).HasColumnName("ANNUALINCOMEID");

                entity.Property(e => e.Approvalstatus).HasColumnName("APPROVALSTATUS");

                entity.Property(e => e.Bankaccountnumber)
                    .HasColumnName("BANKACCOUNTNUMBER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bankaccountopeneddate)
                    .HasColumnName("BANKACCOUNTOPENEDDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Bankaccountypeid).HasColumnName("BANKACCOUNTYPEID");

                entity.Property(e => e.Bankaddress)
                    .HasColumnName("BANKADDRESS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Businesscategoryid).HasColumnName("BUSINESSCATEGORYID");

                entity.Property(e => e.Businessstartdate)
                    .HasColumnName("BUSINESSSTARTDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Businesswebsite)
                    .HasColumnName("BUSINESSWEBSITE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bvn)
                    .HasColumnName("BVN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Creationmailsent).HasColumnName("CREATIONMAILSENT");

                entity.Property(e => e.Creditrating)
                    .HasColumnName("CREDITRATING")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Currentemployer)
                    .HasColumnName("CURRENTEMPLOYER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customeraccounttypeid).HasColumnName("CUSTOMERACCOUNTTYPEID");

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("CUSTOMERCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customersensitivitylevelid).HasColumnName("CUSTOMERSENSITIVITYLEVELID");

                entity.Property(e => e.Dateactedon)
                    .HasColumnName("DATEACTEDON")
                    .HasColumnType("date");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnName("DATEOFBIRTH")
                    .HasColumnType("date");

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.Educationlevel)
                    .HasColumnName("EDUCATIONLEVEL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Employeddate)
                    .HasColumnName("EMPLOYEDDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Employmentstatus).HasColumnName("EMPLOYMENTSTATUS");

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Firstchilddob)
                    .HasColumnName("FIRSTCHILDDOB")
                    .HasColumnType("date");

                entity.Property(e => e.Firstchildname)
                    .HasColumnName("FIRSTCHILDNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Foreignrpno)
                    .HasColumnName("FOREIGNRPNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genderid).HasColumnName("GENDERID");

                entity.Property(e => e.Hometown)
                    .HasColumnName("HOMETOWN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idexpiry)
                    .HasColumnName("IDEXPIRY")
                    .HasColumnType("date");

                entity.Property(e => e.Idissueauthority)
                    .HasColumnName("IDISSUEAUTHORITY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idplaceofissue)
                    .HasColumnName("IDPLACEOFISSUE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Industryid).HasColumnName("INDUSTRYID");

                entity.Property(e => e.Institutiontypeid).HasColumnName("INSTITUTIONTYPEID");

                entity.Property(e => e.Ispoliticallyexposed).HasColumnName("ISPOLITICALLYEXPOSED");

                entity.Property(e => e.Lastupdatedby).HasColumnName("LASTUPDATEDBY");

                entity.Property(e => e.Maritalstatusid).HasColumnName("MARITALSTATUSID");

                entity.Property(e => e.Marriagecertificationdate)
                    .HasColumnName("MARRIAGECERTIFICATIONDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Modeofidentificationid).HasColumnName("MODEOFIDENTIFICATIONID");

                entity.Property(e => e.Mothersmaidenname)
                    .HasColumnName("MOTHERSMAIDENNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Namercparentbody)
                    .HasColumnName("NAMERCPARENTBODY")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Namercrelatedcoys)
                    .HasColumnName("NAMERCRELATEDCOYS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasColumnName("NATIONALITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Natureofbusiness)
                    .HasColumnName("NATUREOFBUSINESS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nokaddress)
                    .HasColumnName("NOKADDRESS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nokdob)
                    .HasColumnName("NOKDOB")
                    .HasColumnType("date");

                entity.Property(e => e.Nokemail)
                    .HasColumnName("NOKEMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nokgenderid).HasColumnName("NOKGENDERID");

                entity.Property(e => e.Nokothernames)
                    .HasColumnName("NOKOTHERNAMES")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nokphone)
                    .HasColumnName("NOKPHONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nokrelationship)
                    .HasColumnName("NOKRELATIONSHIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Noksurname)
                    .HasColumnName("NOKSURNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasColumnName("OCCUPATION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Othernames)
                    .HasColumnName("OTHERNAMES")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Placeofbirth)
                    .HasColumnName("PLACEOFBIRTH")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pobox)
                    .HasColumnName("POBOX")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Previousemployer)
                    .HasColumnName("PREVIOUSEMPLOYER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rcnumber)
                    .HasColumnName("RCNUMBER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");

                entity.Property(e => e.Relationshipofficerid).HasColumnName("RELATIONSHIPOFFICERID");

                entity.Property(e => e.Scumlnumber)
                    .HasColumnName("SCUMLNUMBER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sectorid).HasColumnName("SECTORID");

                entity.Property(e => e.Sourceoffundid).HasColumnName("SOURCEOFFUNDID");

                entity.Property(e => e.Spousemail)
                    .HasColumnName("SPOUSEMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Spousenamework)
                    .HasColumnName("SPOUSENAMEWORK")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Spousephone)
                    .HasColumnName("SPOUSEPHONE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Staffnumber)
                    .HasColumnName("STAFFNUMBER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stateoforiginid).HasColumnName("STATEOFORIGINID");

                entity.Property(e => e.Stateoriginlgaid).HasColumnName("STATEORIGINLGAID");

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Taxidnumber)
                    .HasColumnName("TAXIDNUMBER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Titleid).HasColumnName("TITLEID");

                entity.Property(e => e.Weddingdate)
                    .HasColumnName("WEDDINGDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Workaddress)
                    .HasColumnName("WORKADDRESS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Workcountry).HasColumnName("WORKCOUNTRY");

                entity.Property(e => e.Workphone)
                    .HasColumnName("WORKPHONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Workstate).HasColumnName("WORKSTATE");

                entity.HasOne(d => d.Annualincome)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Annualincomeid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_ANNUALINCOME");

                entity.HasOne(d => d.Bankaccountype)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Bankaccountypeid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_BANKACCOUNTTYPE");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Bankid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_BANK");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Branchid)
                    .HasConstraintName("FK_tbl_Customer_tbl_Branch");

                entity.HasOne(d => d.Businesscategory)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Businesscategoryid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_BUSINESSCATEGORY");

                entity.HasOne(d => d.Customeraccounttype)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Customeraccounttypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_CUSTOMERACCOUNTTYPE");

                entity.HasOne(d => d.Customersensitivitylevel)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Customersensitivitylevelid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_SENSITIVITYLEVEL");

                entity.HasOne(d => d.EmploymentstatusNavigation)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Employmentstatus)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_EMPLOYMENTTYPE");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.TblCustomerGender)
                    .HasForeignKey(d => d.Genderid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_GENDER");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Industryid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_INDUSTRY");

                entity.HasOne(d => d.Institutiontype)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Institutiontypeid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_INSTITUTIONTYPE");

                entity.HasOne(d => d.Maritalstatus)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Maritalstatusid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_MARITAL_STATUS");

                entity.HasOne(d => d.Modeofidentification)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Modeofidentificationid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_MODEOFIDENTIFICATION");

                entity.HasOne(d => d.Nokgender)
                    .WithMany(p => p.TblCustomerNokgender)
                    .HasForeignKey(d => d.Nokgenderid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_GENDER1");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Regionid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_REGION");

                entity.HasOne(d => d.Relationshipofficer)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Relationshipofficerid)
                    .HasConstraintName("FK__TBL_STAFF__TBL_CUSTOMER");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Sectorid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_SECTOR");

                entity.HasOne(d => d.Sourceoffund)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Sourceoffundid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_SOURCEOFFUNDS");

                entity.HasOne(d => d.Stateoforigin)
                    .WithMany(p => p.TblCustomerStateoforigin)
                    .HasForeignKey(d => d.Stateoforiginid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_STATE1");

                entity.HasOne(d => d.Stateoriginlga)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Stateoriginlgaid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_STATEANDLGA");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Titleid)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_TITLE");

                entity.HasOne(d => d.WorkcountryNavigation)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Workcountry)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_COUNTRY");

                entity.HasOne(d => d.WorkstateNavigation)
                    .WithMany(p => p.TblCustomerWorkstateNavigation)
                    .HasForeignKey(d => d.Workstate)
                    .HasConstraintName("FK_TBL_CUSTOMER_TBL_STATE");
            });

            modelBuilder.Entity<TblCustomeraccountalertmedium>(entity =>
            {
                entity.ToTable("TBL_CUSTOMERACCOUNTALERTMEDIUM", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Alertmediumid).HasColumnName("ALERTMEDIUMID");

                entity.Property(e => e.Customeraccountserviceid).HasColumnName("CUSTOMERACCOUNTSERVICEID");

                entity.HasOne(d => d.Alertmedium)
                    .WithMany(p => p.TblCustomeraccountalertmedium)
                    .HasForeignKey(d => d.Alertmediumid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMERACCOUNTALERTMEDIUM_TBL_ACCOUNTALERTMEDIUM");

                entity.HasOne(d => d.Customeraccountservice)
                    .WithMany(p => p.TblCustomeraccountalertmedium)
                    .HasForeignKey(d => d.Customeraccountserviceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMERACCOUNTALERTMEDIUM_TBL_CUSTOMERACCOUNTSERVICE");
            });

            modelBuilder.Entity<TblCustomeraccountbankingservice>(entity =>
            {
                entity.ToTable("TBL_CUSTOMERACCOUNTBANKINGSERVICE", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bankingserviceid).HasColumnName("BANKINGSERVICEID");

                entity.Property(e => e.Customeraccountserviceid).HasColumnName("CUSTOMERACCOUNTSERVICEID");

                entity.HasOne(d => d.Bankingservice)
                    .WithMany(p => p.TblCustomeraccountbankingservice)
                    .HasForeignKey(d => d.Bankingserviceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMERACCOUNTBANKINGSERVICE_TBL_ACCOUNTBANKINGSERVICE");

                entity.HasOne(d => d.Customeraccountservice)
                    .WithMany(p => p.TblCustomeraccountbankingservice)
                    .HasForeignKey(d => d.Customeraccountserviceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMERACCOUNTBANKINGSERVICE_TBL_CUSTOMERACCOUNTSERVICE");
            });

            modelBuilder.Entity<TblCustomeraccountkycitem>(entity =>
            {
                entity.HasKey(e => e.Customeraccountkycitemid);

                entity.ToTable("TBL_CUSTOMERACCOUNTKYCITEM", "Customer");

                entity.Property(e => e.Customeraccountkycitemid).HasColumnName("CUSTOMERACCOUNTKYCITEMID");

                entity.Property(e => e.Actiondate)
                    .HasColumnName("ACTIONDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Actionid).HasColumnName("ACTIONID");

                entity.Property(e => e.Approved).HasColumnName("APPROVED");

                entity.Property(e => e.Approvedby).HasColumnName("APPROVEDBY");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(100);

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Dateapproved).HasColumnName("DATEAPPROVED");

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Disapproved).HasColumnName("DISAPPROVED");

                entity.Property(e => e.Kycitemid).HasColumnName("KYCITEMID");

                entity.Property(e => e.Lastupdatedby).HasColumnName("LASTUPDATEDBY");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.TblCustomeraccountkycitem)
                    .HasForeignKey(d => d.Actionid)
                    .HasConstraintName("FK_TBL_CUSTOMERACCOUNTKYCITEM_TBL_KYCITEMACTION");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomeraccountkycitem)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TBL_CUSTOMERACCOUNTKYCITEM__TBL_CUSTOMER");

                entity.HasOne(d => d.Kycitem)
                    .WithMany(p => p.TblCustomeraccountkycitem)
                    .HasForeignKey(d => d.Kycitemid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMERACCOUNTKYCITEM_TBL_KYCITEM");
            });

            modelBuilder.Entity<TblCustomeraccountservice>(entity =>
            {
                entity.ToTable("TBL_CUSTOMERACCOUNTSERVICE", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cardtypeid).HasColumnName("CARDTYPEID");

                entity.Property(e => e.Casaaccountid).HasColumnName("CASAACCOUNTID");

                entity.Property(e => e.Minbalance).HasColumnName("MINBALANCE");

                entity.Property(e => e.Nameoncard)
                    .HasColumnName("NAMEONCARD")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Statementfrequencyid).HasColumnName("STATEMENTFREQUENCYID");

                entity.HasOne(d => d.Cardtype)
                    .WithMany(p => p.TblCustomeraccountservice)
                    .HasForeignKey(d => d.Cardtypeid)
                    .HasConstraintName("FK_TBL_CUSTOMERACCOUNTSERVICE_TBL_ACCOUNTCARDTYPE");

                entity.HasOne(d => d.Casaaccount)
                    .WithMany(p => p.TblCustomeraccountservice)
                    .HasForeignKey(d => d.Casaaccountid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMERACCOUNTSERVICE_TBL_CASA");

                entity.HasOne(d => d.Statementfrequency)
                    .WithMany(p => p.TblCustomeraccountservice)
                    .HasForeignKey(d => d.Statementfrequencyid)
                    .HasConstraintName("FK_TBL_CUSTOMERACCOUNTSERVICE_TBL_ACCOUNTSTMNTFREQ");
            });

            modelBuilder.Entity<TblCustomeraccountstmntmedium>(entity =>
            {
                entity.ToTable("TBL_CUSTOMERACCOUNTSTMNTMEDIUM", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Customeraccountserviceid).HasColumnName("CUSTOMERACCOUNTSERVICEID");

                entity.Property(e => e.Statementmediumid).HasColumnName("STATEMENTMEDIUMID");

                entity.HasOne(d => d.Customeraccountservice)
                    .WithMany(p => p.TblCustomeraccountstmntmedium)
                    .HasForeignKey(d => d.Customeraccountserviceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMERACCOUNTSTMNTMEDIUM_TBL_CUSTOMERACCOUNTSERVICE");

                entity.HasOne(d => d.Statementmedium)
                    .WithMany(p => p.TblCustomeraccountstmntmedium)
                    .HasForeignKey(d => d.Statementmediumid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMERACCOUNTSTMNTMEDIUM_TBL_ACCOUNTSTMNTMEDIUM");
            });

            modelBuilder.Entity<TblCustomeraccounttype>(entity =>
            {
                entity.ToTable("TBL_CUSTOMERACCOUNTTYPE", "Customer");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_TBL_CUSTOMERACCOUNTTYPE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomeraddress>(entity =>
            {
                entity.HasKey(e => e.Addressid);

                entity.ToTable("TBL_CUSTOMERADDRESS", "Customer");

                entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");

                entity.Property(e => e.Active)
                    .HasColumnName("ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(200);

                entity.Property(e => e.Addresstypeid).HasColumnName("ADDRESSTYPEID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("CITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Electricmeternumber)
                    .HasColumnName("ELECTRICMETERNUMBER")
                    .HasMaxLength(50);

                entity.Property(e => e.Hometown)
                    .HasColumnName("HOMETOWN")
                    .HasMaxLength(200);

                entity.Property(e => e.Nearestlandmark)
                    .HasColumnName("NEARESTLANDMARK")
                    .HasMaxLength(300);

                entity.Property(e => e.Pobox)
                    .HasColumnName("POBOX")
                    .HasMaxLength(200);

                entity.Property(e => e.Stateid).HasColumnName("STATEID");

                entity.HasOne(d => d.Addresstype)
                    .WithMany(p => p.TblCustomeraddress)
                    .HasForeignKey(d => d.Addresstypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMER_ADDRESS_TBL_CUSTOMER_ADDRESS_TYPE");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblCustomeraddress)
                    .HasForeignKey(d => d.Countryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMERADDRESS_TBL_COUNTRY");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomeraddress)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Customer_Residential_Address_tbl_Customer");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblCustomeraddress)
                    .HasForeignKey(d => d.Stateid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMERADDRESS_TBL_STATE");
            });

            modelBuilder.Entity<TblCustomeraddresstype>(entity =>
            {
                entity.HasKey(e => e.Addresstypeid);

                entity.ToTable("TBL_CUSTOMERADDRESSTYPE", "Customer");

                entity.Property(e => e.Addresstypeid)
                    .HasColumnName("ADDRESSTYPEID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressTypeName)
                    .IsRequired()
                    .HasColumnName("ADDRESS_TYPE_NAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCustomerblacklist>(entity =>
            {
                entity.HasKey(e => e.CustomerBlacklistid);

                entity.ToTable("TBL_CUSTOMERBLACKLIST", "Customer");

                entity.Property(e => e.CustomerBlacklistid).HasColumnName("CUSTOMER_BLACKLISTID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Dateblacklisted)
                    .HasColumnName("DATEBLACKLISTED")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Iscurrent)
                    .HasColumnName("ISCURRENT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblCustomerblacklist)
                    .HasForeignKey(d => d.Companyid)
                    .HasConstraintName("FK_TBL_CUSTOMER_BLACKLIST_TBL_COMPANY");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerblacklist)
                    .HasForeignKey(d => d.Customerid)
                    .HasConstraintName("FK_TBL_CUSTOMER_BLACKLIST_TBL_CUSTOMER");
            });

            modelBuilder.Entity<TblCustomerbvn>(entity =>
            {
                entity.HasKey(e => e.Customerbvnid);

                entity.ToTable("TBL_CUSTOMERBVN", "Customer");

                entity.Property(e => e.Customerbvnid).HasColumnName("CUSTOMERBVNID");

                entity.Property(e => e.Bankverificationnumber)
                    .IsRequired()
                    .HasColumnName("BANKVERIFICATIONNUMBER")
                    .HasMaxLength(20);

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Ispoliticallyexposed).HasColumnName("ISPOLITICALLYEXPOSED");

                entity.Property(e => e.Isvalidbvn).HasColumnName("ISVALIDBVN");

                entity.Property(e => e.Lastupdatedby).HasColumnName("LASTUPDATEDBY");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("SURNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCustomerCustomFields>(entity =>
            {
                entity.ToTable("tbl_CustomerCustomFields", "Customer");

                entity.Property(e => e.Caption1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption10)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption11)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption12)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption13)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption14)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption15)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption16)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption17)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption18)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption19)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption20)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption3)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption4)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption5)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption6)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption7)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption8)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Caption9)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomeremailcontact>(entity =>
            {
                entity.HasKey(e => e.Emailcontactid);

                entity.ToTable("TBL_CUSTOMEREMAILCONTACT", "Customer");

                entity.Property(e => e.Emailcontactid).HasColumnName("EMAILCONTACTID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomeremailcontact)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMER_EMAILCONTACT_TBL_CUSTOMER");
            });

            modelBuilder.Entity<TblCustomeremploymenthistory>(entity =>
            {
                entity.HasKey(e => e.Placeofworkid);

                entity.ToTable("TBL_CUSTOMEREMPLOYMENTHISTORY", "Customer");

                entity.Property(e => e.Placeofworkid).HasColumnName("PLACEOFWORKID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Employdate)
                    .HasColumnName("EMPLOYDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Employeraddress)
                    .IsRequired()
                    .HasColumnName("EMPLOYERADDRESS")
                    .HasMaxLength(200);

                entity.Property(e => e.Employercountryid).HasColumnName("EMPLOYERCOUNTRYID");

                entity.Property(e => e.Employername)
                    .IsRequired()
                    .HasColumnName("EMPLOYERNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Employerstateid).HasColumnName("EMPLOYERSTATEID");

                entity.Property(e => e.Officephone)
                    .IsRequired()
                    .HasColumnName("OFFICEPHONE")
                    .HasMaxLength(200);

                entity.Property(e => e.Previousemployer)
                    .HasColumnName("PREVIOUSEMPLOYER")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblCustomergroup>(entity =>
            {
                entity.HasKey(e => e.Groupid);

                entity.ToTable("TBL_CUSTOMERGROUP", "Customer");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Branch)
                    .HasColumnName("BRANCH")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Groupname)
                    .IsRequired()
                    .HasColumnName("GROUPNAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Iscommittee).HasColumnName("ISCOMMITTEE");

                entity.Property(e => e.Lastupdated)
                    .HasColumnName("LASTUPDATED")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<TblCustomeridentification>(entity =>
            {
                entity.HasKey(e => e.Identificationid);

                entity.ToTable("TBL_CUSTOMERIDENTIFICATION", "Customer");

                entity.Property(e => e.Identificationid).HasColumnName("IDENTIFICATIONID");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Identificationmodeid).HasColumnName("IDENTIFICATIONMODEID");

                entity.Property(e => e.Identificationno)
                    .HasColumnName("IDENTIFICATIONNO")
                    .HasMaxLength(25);

                entity.Property(e => e.Issueauthority)
                    .HasColumnName("ISSUEAUTHORITY")
                    .HasMaxLength(200);

                entity.Property(e => e.Issueplace)
                    .HasColumnName("ISSUEPLACE")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomeridentification)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Customer_Identification_tbl_Customer");

                entity.HasOne(d => d.Identificationmode)
                    .WithMany(p => p.TblCustomeridentification)
                    .HasForeignKey(d => d.Identificationmodeid)
                    .HasConstraintName("FK_tbl_Customer_Identification_tbl_Customer_IdentificationMode");
            });

            modelBuilder.Entity<TblCustomeridentimodetype>(entity =>
            {
                entity.HasKey(e => e.Identificationmodeid);

                entity.ToTable("TBL_CUSTOMERIDENTIMODETYPE", "Customer");

                entity.Property(e => e.Identificationmodeid).HasColumnName("IDENTIFICATIONMODEID");

                entity.Property(e => e.Identificationmode)
                    .IsRequired()
                    .HasColumnName("IDENTIFICATIONMODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomernextofkin>(entity =>
            {
                entity.HasKey(e => e.Nextofkinid);

                entity.ToTable("TBL_CUSTOMERNEXTOFKIN", "Customer");

                entity.Property(e => e.Nextofkinid).HasColumnName("NEXTOFKINID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Nestofkinaddress)
                    .IsRequired()
                    .HasColumnName("NESTOFKINADDRESS")
                    .HasMaxLength(200);

                entity.Property(e => e.Nestofkinemail)
                    .HasColumnName("NESTOFKINEMAIL")
                    .HasMaxLength(200);

                entity.Property(e => e.Nextofkinfirstname)
                    .IsRequired()
                    .HasColumnName("NEXTOFKINFIRSTNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Nextofkinname)
                    .IsRequired()
                    .HasColumnName("NEXTOFKINNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Nextofkinphonenumber)
                    .HasColumnName("NEXTOFKINPHONENUMBER")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomernextofkin)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Customer_NextOfKin_tbl_Customer");
            });

            modelBuilder.Entity<TblCustomerphonecontact>(entity =>
            {
                entity.HasKey(e => e.Phonecontactid);

                entity.ToTable("TBL_CUSTOMERPHONECONTACT", "Customer");

                entity.Property(e => e.Phonecontactid).HasColumnName("PHONECONTACTID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("PHONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerphonecontact)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Customer_PhoneContact_tbl_Customer");
            });

            modelBuilder.Entity<TblCustomersignatory>(entity =>
            {
                entity.HasKey(e => e.CustomerSignatoryid);

                entity.ToTable("TBL_CUSTOMERSIGNATORY", "Customer");

                entity.Property(e => e.CustomerSignatoryid).HasColumnName("CUSTOMER_SIGNATORYID");

                entity.Property(e => e.Bvn)
                    .IsRequired()
                    .HasColumnName("BVN")
                    .HasMaxLength(50);

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("GENDER")
                    .HasMaxLength(10);

                entity.Property(e => e.Middlename)
                    .HasColumnName("MIDDLENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("SURNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.ToTable("TBL_DEPARTMENT", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Department)
                    .HasColumnName("DEPARTMENT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Departmentcode)
                    .HasColumnName("DEPARTMENTCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unitcode)
                    .HasColumnName("UNITCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unitname)
                    .HasColumnName("UNITNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblDepartment)
                    .HasForeignKey(d => d.Branchid)
                    .HasConstraintName("FK_TBL_DEPARTMENT_TBL_BRANCH");
            });

            modelBuilder.Entity<TblEditedcustomer>(entity =>
            {
                entity.HasKey(e => e.Customerid);

                entity.ToTable("TBL_EDITEDCUSTOMER", "Customer");

                entity.HasIndex(e => new { e.Customercode, e.Companyid })
                    .HasName("UQ__tbl_Edited_Cust__A25C5AA7ACCCA9B2")
                    .IsUnique();

                entity.Property(e => e.Customerid)
                    .HasColumnName("CUSTOMERID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Actedonby)
                    .HasColumnName("ACTEDONBY")
                    .HasMaxLength(150);

                entity.Property(e => e.Annualincomeid).HasColumnName("ANNUALINCOMEID");

                entity.Property(e => e.Approvalstatus).HasColumnName("APPROVALSTATUS");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Customeraccounttypeid).HasColumnName("CUSTOMERACCOUNTTYPEID");

                entity.Property(e => e.Customerbvn)
                    .HasColumnName("CUSTOMERBVN")
                    .HasMaxLength(50);

                entity.Property(e => e.Customercode)
                    .IsRequired()
                    .HasColumnName("CUSTOMERCODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Customersensitivitylevelid).HasColumnName("CUSTOMERSENSITIVITYLEVELID");

                entity.Property(e => e.Dateactedon)
                    .HasColumnName("DATEACTEDON")
                    .HasColumnType("date");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnName("DATEOFBIRTH")
                    .HasColumnType("date");

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.Emailaddress)
                    .HasColumnName("EMAILADDRESS")
                    .HasMaxLength(100);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Fscaptiongroupid).HasColumnName("FSCAPTIONGROUPID");

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasMaxLength(10);

                entity.Property(e => e.Genderid).HasColumnName("GENDERID");

                entity.Property(e => e.Isinvestmentgrade).HasColumnName("ISINVESTMENTGRADE");

                entity.Property(e => e.Ispoliticallyexposed).HasColumnName("ISPOLITICALLYEXPOSED");

                entity.Property(e => e.Isrealatedparty).HasColumnName("ISREALATEDPARTY");

                entity.Property(e => e.Lastname)
                    .HasColumnName("LASTNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Lastupdatedby).HasColumnName("LASTUPDATEDBY");

                entity.Property(e => e.Maidenname)
                    .HasColumnName("MAIDENNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Maritalstatus).HasColumnName("MARITALSTATUS");

                entity.Property(e => e.Maritalstatusid).HasColumnName("MARITALSTATUSID");

                entity.Property(e => e.Middlename)
                    .HasColumnName("MIDDLENAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Miscode)
                    .HasColumnName("MISCODE")
                    .HasMaxLength(200);

                entity.Property(e => e.Misstaff)
                    .HasColumnName("MISSTAFF")
                    .HasMaxLength(200);

                entity.Property(e => e.Modeofidentificationid).HasColumnName("MODEOFIDENTIFICATIONID");

                entity.Property(e => e.Nationality)
                    .HasColumnName("NATIONALITY")
                    .HasMaxLength(20);

                entity.Property(e => e.Occupation)
                    .HasColumnName("OCCUPATION")
                    .HasMaxLength(100);

                entity.Property(e => e.Placeofbirth)
                    .HasColumnName("PLACEOFBIRTH")
                    .HasMaxLength(200);

                entity.Property(e => e.Relationshipofficerid).HasColumnName("RELATIONSHIPOFFICERID");

                entity.Property(e => e.Riskratingid).HasColumnName("RISKRATINGID");

                entity.Property(e => e.Spouse)
                    .HasColumnName("SPOUSE")
                    .HasMaxLength(200);

                entity.Property(e => e.Stateandlgaid).HasColumnName("STATEANDLGAID");

                entity.Property(e => e.Subsectorid).HasColumnName("SUBSECTORID");

                entity.Property(e => e.Taxnumber)
                    .HasColumnName("TAXNUMBER")
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(50);

                entity.Property(e => e.Titleid).HasColumnName("TITLEID");

                entity.HasOne(d => d.Annualincome)
                    .WithMany(p => p.TblEditedcustomerAnnualincome)
                    .HasForeignKey(d => d.Annualincomeid)
                    .HasConstraintName("FK_TBL_EDITED_CUSTOMER_TBL_ANNUALINCOMEID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblEditedcustomer)
                    .HasForeignKey(d => d.Branchid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Edited_Customer_tbl_Branch");

                entity.HasOne(d => d.Customer)
                    .WithOne(p => p.TblEditedcustomerCustomer)
                    .HasForeignKey<TblEditedcustomer>(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_EDITED_CUSTOMER_TBL_ANNUAL_INCOME");

                entity.HasOne(d => d.GenderNavigation)
                    .WithMany(p => p.TblEditedcustomer)
                    .HasForeignKey(d => d.Genderid)
                    .HasConstraintName("FK_TBL_EDITED_CUSTOMER_TBL_GENDER");

                entity.HasOne(d => d.MaritalstatusNavigation)
                    .WithMany(p => p.TblEditedcustomer)
                    .HasForeignKey(d => d.Maritalstatusid)
                    .HasConstraintName("FK_TBL_EDITED_CUSTOMER_TBL_MARITAL_STATUS");

                entity.HasOne(d => d.Modeofidentification)
                    .WithMany(p => p.TblEditedcustomer)
                    .HasForeignKey(d => d.Modeofidentificationid)
                    .HasConstraintName("FK_TBL_EDITED_CUSTOMER_TBL_MODEOFIDENTIFICATION");

                entity.HasOne(d => d.Relationshipofficer)
                    .WithMany(p => p.TblEditedcustomer)
                    .HasForeignKey(d => d.Relationshipofficerid)
                    .HasConstraintName("FK__tbl_Edited_Custo__Relat__1332DBDC");

                entity.HasOne(d => d.TitleNavigation)
                    .WithMany(p => p.TblEditedcustomer)
                    .HasForeignKey(d => d.Titleid)
                    .HasConstraintName("FK_TBL_EDITED_CUSTOMER_TBL_TITLE");
            });

            modelBuilder.Entity<TblEmploymenttype>(entity =>
            {
                entity.ToTable("TBL_EMPLOYMENTTYPE", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblFinanceAccountCategory>(entity =>
            {
                entity.ToTable("tbl_FinanceAccountCategory", "Finance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountGroupId).HasColumnName("AccountGroupID");

                entity.Property(e => e.Active)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descriptions)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceAccountGroup>(entity =>
            {
                entity.ToTable("tbl_FinanceAccountGroup", "Finance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceAccountSub>(entity =>
            {
                entity.ToTable("tbl_FinanceAccountSub", "Finance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSubId)
                    .HasColumnName("AccountSubID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSubName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceAccountType>(entity =>
            {
                entity.ToTable("tbl_FinanceAccountType", "Finance");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountCategoryId).HasColumnName("AccountCategoryID");

                entity.Property(e => e.Active)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MainCaptionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubCaptionId).HasColumnName("SubCaptionID");
            });

            modelBuilder.Entity<TblFinanceAccountType1>(entity =>
            {
                entity.ToTable("tbl_FinanceAccountType");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountCategoryId).HasColumnName("AccountCategoryID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MainCaptionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubCaptionId).HasColumnName("SubCaptionID");
            });

            modelBuilder.Entity<TblFinanceBank>(entity =>
            {
                entity.ToTable("tbl_FinanceBank", "Finance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccNo)
                    .HasColumnName("Acc_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankId)
                    .HasColumnName("BankID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceBankReconciliation>(entity =>
            {
                entity.ToTable("tbl_FinanceBankReconciliation", "Finance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankAccNos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankGlaccNos)
                    .IsRequired()
                    .HasColumnName("BankGLAccNos")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankReconId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Brcode)
                    .HasColumnName("brcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClosingBnkStatementBal).HasColumnType("money");

                entity.Property(e => e.Coycode)
                    .HasColumnName("coycode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Glbalance)
                    .HasColumnName("GLBalance")
                    .HasColumnType("money");

                entity.Property(e => e.OpeningBnkStatementBal).HasColumnType("money");

                entity.Property(e => e.ReconciliationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblFinanceBankStatementsItems>(entity =>
            {
                entity.ToTable("tbl_FinanceBankStatementsItems", "Finance");

                entity.Property(e => e.Approvedby)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankId)
                    .HasColumnName("BankID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankReconId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brcode)
                    .HasColumnName("brcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Coycode)
                    .HasColumnName("coycode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.CreditAccountId)
                    .HasColumnName("CreditAccountID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.DebitAccountId)
                    .HasColumnName("DebitAccountID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EntryBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Postedby)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReconciliationDate).HasColumnType("datetime");

                entity.Property(e => e.Reference).IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceBonuses>(entity =>
            {
                entity.HasKey(e => e.BonusId);

                entity.ToTable("tbl_FinanceBonuses", "Finance");

                entity.Property(e => e.BonusId).HasColumnName("BonusID");

                entity.Property(e => e.ClosureDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.ForEvery).HasColumnType("money");

                entity.Property(e => e.MadeBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Security)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Unit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Year)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceBonusesGeneral>(entity =>
            {
                entity.HasKey(e => e.BonusId);

                entity.ToTable("tbl_FinanceBonusesGeneral", "Finance");

                entity.Property(e => e.BonusId).HasColumnName("BonusID");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClosureDate).HasColumnType("datetime");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.MadeBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Security).IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Unit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Year)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceChartOfAccount>(entity =>
            {
                entity.ToTable("tbl_FinanceChartOfAccount", "Finance");

                entity.Property(e => e.AccountCategoryId).HasColumnName("AccountCategoryID");

                entity.Property(e => e.AccountGroupId).HasColumnName("AccountGroupID");

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasColumnName("AccountID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.BrId)
                    .HasColumnName("brID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyId)
                    .IsRequired()
                    .HasColumnName("coyID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FscaptionCode)
                    .HasColumnName("FSCaptionCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldAccountId)
                    .HasColumnName("OldAccountID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OldAccountId1)
                    .HasColumnName("OldAccountID1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OldAccountId2)
                    .HasColumnName("OldAccountID2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RelationShip)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StCode).HasColumnName("stCode");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceCostCenter>(entity =>
            {
                entity.ToTable("tbl_FinanceCostCenter", "Finance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Costname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceCounterpartyTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("tbl_FinanceCounterpartyTransaction", "Finance");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("ApplicationID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BatchRef)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CVolume).HasColumnName("cVolume");

                entity.Property(e => e.Coy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpId)
                    .HasColumnName("cpID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("money");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DVolume).HasColumnName("dVolume");

                entity.Property(e => e.DebitAmount).HasColumnType("money");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.FormNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountId)
                    .HasColumnName("GLAccountID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Legtype)
                    .HasColumnName("legtype")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Show).HasColumnName("show");

                entity.Property(e => e.SystemDateTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrCode);

                entity.ToTable("tbl_FinanceCurrency", "Finance");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrSymbol)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(10, 4)");
            });

            modelBuilder.Entity<TblFinanceCurrentDate>(entity =>
            {
                entity.ToTable("tbl_FinanceCurrentDate", "Finance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblFinanceDefaultAccounts>(entity =>
            {
                entity.HasKey(e => e.DfId);

                entity.ToTable("tbl_FinanceDefaultAccounts", "Finance");

                entity.Property(e => e.DfId).HasColumnName("dfID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("smalldatetime");

                entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.DfDescription)
                    .HasColumnName("dfDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FinancePnc)
                    .HasColumnName("FinancePNC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FinancePnd)
                    .HasColumnName("FinancePND")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("smalldatetime");

                entity.Property(e => e.TellerPnc)
                    .HasColumnName("TellerPNC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TellerPnd)
                    .HasColumnName("TellerPND")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceGlmapping>(entity =>
            {
                entity.ToTable("tbl_FinanceGLMapping", "Finance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinTrakGl)
                    .HasColumnName("FinTrakGL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FinTrakGlcode)
                    .HasColumnName("FinTrakGLCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtherGl)
                    .HasColumnName("OtherGL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OtherGlcode)
                    .HasColumnName("OtherGLCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceStatus>(entity =>
            {
                entity.HasKey(e => e.StCode);

                entity.ToTable("tbl_FinanceStatus", "Finance");

                entity.Property(e => e.StCode).HasColumnName("stCode");

                entity.Property(e => e.StStatus)
                    .IsRequired()
                    .HasColumnName("stStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinanceTransaction>(entity =>
            {
                entity.ToTable("tbl_FinanceTransaction", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("ApplicationID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchRef).IsUnicode(false);

                entity.Property(e => e.CreditAmt).HasColumnType("money");

                entity.Property(e => e.DebitAmt).HasColumnType("money");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DestinationBranch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid)
                    .HasColumnName("ITEMID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LcurrencyCode)
                    .HasColumnName("LCurrencyCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Legtype)
                    .HasColumnName("LEGTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Miscode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NonBrAccountId)
                    .HasColumnName("NonBrAccountID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostingTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ref).IsUnicode(false);

                entity.Property(e => e.SCoyCode)
                    .HasColumnName("sCoyCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sbu)
                    .HasColumnName("SBU")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SourceBranch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblGender>(entity =>
            {
                entity.ToTable("TBL_GENDER", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<TblGrantreversalprivilege>(entity =>
            {
                entity.HasKey(e => e.Reversalsetupid);

                entity.ToTable("TBL_GRANTREVERSALPRIVILEGE", "Retail");

                entity.Property(e => e.Reversalsetupid).HasColumnName("REVERSALSETUPID");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Canreversealltransaction).HasColumnName("CANREVERSEALLTRANSACTION");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Staffinformationid)
                    .IsRequired()
                    .HasColumnName("STAFFINFORMATIONID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblIndustry>(entity =>
            {
                entity.HasKey(e => e.Industryid);

                entity.ToTable("TBL_INDUSTRY", "Customer");

                entity.Property(e => e.Industryid).HasColumnName("INDUSTRYID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sectorid).HasColumnName("SECTORID");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.TblIndustry)
                    .HasForeignKey(d => d.Sectorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_INDUSTRY_TBL_SECTOR");
            });

            modelBuilder.Entity<TblInsertcustomerprofile>(entity =>
            {
                entity.ToTable("TBL_INSERTCUSTOMERPROFILE", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountTypeId).HasColumnName("BankAccountTypeID");

                entity.Property(e => e.BankAddress).IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bvn)
                    .HasColumnName("BVN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CurrentEmployer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Customercode)
                    .HasColumnName("CUSTOMERCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.EducationLevel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerAddress).IsUnicode(false);

                entity.Property(e => e.EmployerTelephone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentDate).HasColumnType("date");

                entity.Property(e => e.FirstChildDob)
                    .HasColumnName("FirstChildDOB")
                    .HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForeignResidentialPermitNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeTown)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificationNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idexpiry)
                    .HasColumnName("IDExpiry")
                    .HasColumnType("date");

                entity.Property(e => e.IdissueAuthority)
                    .HasColumnName("IDIssueAuthority")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdplaceOfIssue)
                    .HasColumnName("IDPlaceOfIssue")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lgaid).HasColumnName("LGAID");

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.MarriageCertificationDate).HasColumnType("date");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfIdentityId).HasColumnName("ModeOfIdentityID");

                entity.Property(e => e.NameOfFirstChild)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.NextOfKinAddress).IsUnicode(false);

                entity.Property(e => e.NextOfKinDob)
                    .HasColumnName("NextOfKinDOB")
                    .HasColumnType("date");

                entity.Property(e => e.NextOfKinEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKinFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKinLastname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKinOtherName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKinPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKinRelationship)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfBirth)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousEmployer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessTypeId).HasColumnName("ProcessTypeID");

                entity.Property(e => e.Rbscategory).HasColumnName("RBSCategory");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.ResidentialAddress).IsUnicode(false);

                entity.Property(e => e.SecondaryEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpouseEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpouseName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpousePhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.TitleId).HasColumnName("TitleID");

                entity.HasOne(d => d.BankAccountType)
                    .WithMany(p => p.TblInsertcustomerprofile)
                    .HasForeignKey(d => d.BankAccountTypeId)
                    .HasConstraintName("FK_TBL_INSERT_CUSTOMER_PROFILE_TBL_BANK_ACCOUNT_TYPE");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblInsertcustomerprofile)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_TBL_INSERT_CUSTOMER_PROFILE_TBL_COMPANY");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.TblInsertcustomerprofile)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_INSERT_CUSTOMER_PROFILE_TBL_GENDER");

                entity.HasOne(d => d.Lga)
                    .WithMany(p => p.TblInsertcustomerprofile)
                    .HasForeignKey(d => d.Lgaid)
                    .HasConstraintName("FK_TBL_INSERT_CUSTOMER_PROFILE_TBL_STATE_AND_LGA");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.TblInsertcustomerprofile)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_TBL_INSERT_CUSTOMER_PROFILE_TBL_MARITAL_STATUS");

                entity.HasOne(d => d.ModeOfIdentity)
                    .WithMany(p => p.TblInsertcustomerprofile)
                    .HasForeignKey(d => d.ModeOfIdentityId)
                    .HasConstraintName("FK_TBL_INSERT_CUSTOMER_PROFILE_TBL_MODEOFIDENTIFICATION");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.TblInsertcustomerprofile)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_TBL_INSERT_CUSTOMER_PROFILE_TBL_COUNTRY");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.TblInsertcustomerprofile)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_INSERT_CUSTOMER_PROFILE_TBL_REGION");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblInsertcustomerprofile)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_TBL_INSERT_CUSTOMER_PROFILE_TBL_STATE");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.TblInsertcustomerprofile)
                    .HasForeignKey(d => d.TitleId)
                    .HasConstraintName("FK_TBL_INSERT_CUSTOMER_PROFILE_TBL_TITLE");
            });

            modelBuilder.Entity<TblInstitutiontype>(entity =>
            {
                entity.ToTable("TBL_INSTITUTIONTYPE", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Typename)
                    .IsRequired()
                    .HasColumnName("TYPENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInwardbankcheque>(entity =>
            {
                entity.ToTable("TBL_INWARDBANKCHEQUE", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Amountdifference)
                    .HasColumnName("AMOUNTDIFFERENCE")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Approved).HasColumnName("APPROVED");

                entity.Property(e => e.Approvedby)
                    .HasColumnName("APPROVEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branchid)
                    .HasColumnName("BRANCHID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Casaaccountname)
                    .IsRequired()
                    .HasColumnName("CASAACCOUNTNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Casaaccountno)
                    .IsRequired()
                    .HasColumnName("CASAACCOUNTNO")
                    .HasMaxLength(50);

                entity.Property(e => e.Chargeamount)
                    .HasColumnName("CHARGEAMOUNT")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Chargecot).HasColumnName("CHARGECOT");

                entity.Property(e => e.Chargeglid).HasColumnName("CHARGEGLID");

                entity.Property(e => e.Chargepercent)
                    .HasColumnName("CHARGEPERCENT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Chequeno)
                    .IsRequired()
                    .HasColumnName("CHEQUENO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Companyid)
                    .HasColumnName("COMPANYID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cotamount)
                    .HasColumnName("COTAMOUNT")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateapproved)
                    .HasColumnName("DATEAPPROVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isdiscountcharge).HasColumnName("ISDISCOUNTCHARGE");

                entity.Property(e => e.Isreturncharge).HasColumnName("ISRETURNCHARGE");

                entity.Property(e => e.Isreturned).HasColumnName("ISRETURNED");

                entity.Property(e => e.Isreversed).HasColumnName("ISREVERSED");

                entity.Property(e => e.Narration)
                    .HasColumnName("NARRATION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Operationid).HasColumnName("OPERATIONID");

                entity.Property(e => e.Otherreturncheque).HasColumnName("OTHERRETURNCHEQUE");

                entity.Property(e => e.Principalglid).HasColumnName("PRINCIPALGLID");

                entity.Property(e => e.Reusecheque).HasColumnName("REUSECHEQUE");

                entity.Property(e => e.Transactiondate)
                    .HasColumnName("TRANSACTIONDATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblKycdocumenttype>(entity =>
            {
                entity.HasKey(e => e.Documenttypeid);

                entity.ToTable("TBL_KYCDOCUMENTTYPE", "Customer");

                entity.Property(e => e.Documenttypeid).HasColumnName("DOCUMENTTYPEID");

                entity.Property(e => e.Documenttypename)
                    .HasColumnName("DOCUMENTTYPENAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblKycitem>(entity =>
            {
                entity.HasKey(e => e.Kycitemid);

                entity.ToTable("TBL_KYCITEM", "Customer");

                entity.Property(e => e.Kycitemid).HasColumnName("KYCITEMID");

                entity.Property(e => e.Accounttypeid).HasColumnName("ACCOUNTTYPEID");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Displayorder).HasColumnName("DISPLAYORDER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Ismandatory).HasColumnName("ISMANDATORY");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasColumnName("ITEM")
                    .HasMaxLength(500);

                entity.Property(e => e.Lastupdatedby).HasColumnName("LASTUPDATEDBY");

                entity.HasOne(d => d.Accounttype)
                    .WithMany(p => p.TblKycitem)
                    .HasForeignKey(d => d.Accounttypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_KYCITEM_TBL_CUSTOMERACCOUNTTYPE");
            });

            modelBuilder.Entity<TblKycitemaction>(entity =>
            {
                entity.ToTable("TBL_KYCITEMACTION", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMaintenanceaccountdetails>(entity =>
            {
                entity.ToTable("TBL_MAINTENANCEACCOUNTDETAILS", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Atmbanking).HasColumnName("ATMBanking");

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Coycode)
                    .HasColumnName("coycode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.Ibanking).HasColumnName("IBanking");

                entity.Property(e => e.Mbanking).HasColumnName("MBanking");

                entity.Property(e => e.MgrPccode)
                    .HasColumnName("MgrPCCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpCode).HasColumnName("opCode");

                entity.Property(e => e.Pccode)
                    .HasColumnName("PCCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipManager)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipOfficer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipOfficerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Smsalert).HasColumnName("SMSAlert");
            });

            modelBuilder.Entity<TblMaintenancetrack>(entity =>
            {
                entity.ToTable("TBL_MAINTENANCETRACK", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Coy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);
            });

            modelBuilder.Entity<TblMandate>(entity =>
            {
                entity.HasKey(e => e.Mandateid);

                entity.ToTable("TBL_MANDATE", "Customer");

                entity.Property(e => e.Mandateid).HasColumnName("MANDATEID");

                entity.Property(e => e.Bvn)
                    .IsRequired()
                    .HasColumnName("BVN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Casaaccountid).HasColumnName("CASAACCOUNTID");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateofarrival)
                    .HasColumnName("DATEOFARRIVAL")
                    .HasColumnType("date");

                entity.Property(e => e.Dateofdeparture)
                    .HasColumnName("DATEOFDEPARTURE")
                    .HasColumnType("date");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Passportexpirydate)
                    .HasColumnName("PASSPORTEXPIRYDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Passportissuedate)
                    .HasColumnName("PASSPORTISSUEDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Passportno)
                    .HasColumnName("PASSPORTNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pin)
                    .HasColumnName("PIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Residentpermitno)
                    .HasColumnName("RESIDENTPERMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Signatoryaddress)
                    .HasColumnName("SIGNATORYADDRESS")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Signatoryaddress2)
                    .HasColumnName("SIGNATORYADDRESS2")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Signatoryclass)
                    .HasColumnName("SIGNATORYCLASS")
                    .HasMaxLength(1);

                entity.Property(e => e.Signatorydesignation)
                    .HasColumnName("SIGNATORYDESIGNATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Signatorydob)
                    .HasColumnName("SIGNATORYDOB")
                    .HasColumnType("date");

                entity.Property(e => e.Signatoryemail)
                    .HasColumnName("SIGNATORYEMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Signatoryfirstname)
                    .HasColumnName("SIGNATORYFIRSTNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Signatorymodeofid).HasColumnName("SIGNATORYMODEOFID");

                entity.Property(e => e.Signatoryothername)
                    .HasColumnName("SIGNATORYOTHERNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Signatoryphone)
                    .HasColumnName("SIGNATORYPHONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Signatoryphone2)
                    .HasColumnName("SIGNATORYPHONE2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Signatoryphone3)
                    .HasColumnName("SIGNATORYPHONE3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Signatorysurname)
                    .IsRequired()
                    .HasColumnName("SIGNATORYSURNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Signatorytitleid).HasColumnName("SIGNATORYTITLEID");

                entity.Property(e => e.Signatorywedding)
                    .HasColumnName("SIGNATORYWEDDING")
                    .HasColumnType("date");

                entity.Property(e => e.Visavalidfrom)
                    .HasColumnName("VISAVALIDFROM")
                    .HasColumnType("date");

                entity.Property(e => e.Visavalidto)
                    .HasColumnName("VISAVALIDTO")
                    .HasColumnType("date");

                entity.HasOne(d => d.Casaaccount)
                    .WithMany(p => p.TblMandate)
                    .HasForeignKey(d => d.Casaaccountid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_MANDATE_TBL_CASA");
            });

            modelBuilder.Entity<TblMaritalstatus>(entity =>
            {
                entity.ToTable("TBL_MARITALSTATUS", "Customer");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_TBL_MARITALSTATUS")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("date");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMmarketFrozenCallAccount>(entity =>
            {
                entity.ToTable("tbl_MMarketFrozenCallAccount", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AmountFrozenBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovingRemark).IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CpId)
                    .HasColumnName("cpID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentAcct)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateFrozen).HasColumnType("datetime");

                entity.Property(e => e.DealId)
                    .HasColumnName("DealID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FreezingType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FreezingTypeId)
                    .HasColumnName("FreezingTypeID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");
            });

            modelBuilder.Entity<TblMmarketUnfrozenCallAccount>(entity =>
            {
                entity.ToTable("tbl_MMarketUnfrozenCallAccount", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AmountUnFrozenBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovingRemark).IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CpId)
                    .HasColumnName("cpID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentAcct)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateUnFrozen).HasColumnType("datetime");

                entity.Property(e => e.DealId)
                    .HasColumnName("DealID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.UnFreezingType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnFreezingTypeId)
                    .HasColumnName("UnFreezingTypeID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblModeofidentification>(entity =>
            {
                entity.ToTable("TBL_MODEOFIDENTIFICATION", "Customer");

                entity.HasIndex(e => e.Idmode)
                    .HasName("IX_TBL_MODEOFIDENTIFICATION")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Companycode).HasColumnName("COMPANYCODE");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("CREATEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idmode)
                    .IsRequired()
                    .HasColumnName("IDMODE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");
            });

            modelBuilder.Entity<TblMultipleAccountToCreditFundTransfer>(entity =>
            {
                entity.ToTable("tbl_MultipleAccountToCredit_FundTransfer", "Finance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Narration)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.ReciepNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TransCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMultipleAccountToDebitFundTransfer>(entity =>
            {
                entity.ToTable("tbl_MultipleAccountToDebit_FundTransfer", "Finance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Narration)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblNatureofbusiness>(entity =>
            {
                entity.HasKey(e => e.Natureofbusinessid);

                entity.ToTable("TBL_NATUREOFBUSINESS", "Customer");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__TBL_NATU__D9C1FA009CC46C37")
                    .IsUnique();

                entity.Property(e => e.Natureofbusinessid).HasColumnName("NATUREOFBUSINESSID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblOperationtype>(entity =>
            {
                entity.ToTable("TBL_OPERATIONTYPE", "Retail");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Datedeleted)
                    .HasColumnName("DATEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Operationcode).HasColumnName("OPERATIONCODE");

                entity.Property(e => e.Operationname)
                    .HasColumnName("OPERATIONNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOutwardbankcheque>(entity =>
            {
                entity.ToTable("TBL_OUTWARDBANKCHEQUE", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountno)
                    .IsRequired()
                    .HasColumnName("ACCOUNTNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Approvalremark)
                    .HasColumnName("APPROVALREMARK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Approvalstatus).HasColumnName("APPROVALSTATUS");

                entity.Property(e => e.Approvedby)
                    .HasColumnName("APPROVEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bankledgerid)
                    .IsRequired()
                    .HasColumnName("BANKLEDGERID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Branchcode)
                    .HasColumnName("BRANCHCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Chargestampamount).HasColumnName("CHARGESTAMPAMOUNT");

                entity.Property(e => e.Chargestampduty).HasColumnName("CHARGESTAMPDUTY");

                entity.Property(e => e.Chequedate)
                    .HasColumnName("CHEQUEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Chequeno)
                    .IsRequired()
                    .HasColumnName("CHEQUENO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cleardate)
                    .HasColumnName("CLEARDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Clearedby)
                    .HasColumnName("CLEAREDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Clearingoption).HasColumnName("CLEARINGOPTION");

                entity.Property(e => e.Clearingremark)
                    .HasColumnName("CLEARINGREMARK")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Companycode)
                    .HasColumnName("COMPANYCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateapproved)
                    .HasColumnName("DATEAPPROVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datecleared)
                    .HasColumnName("DATECLEARED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Narration)
                    .HasColumnName("NARRATION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Operationid).HasColumnName("OPERATIONID");

                entity.Property(e => e.Operationremark)
                    .HasColumnName("OPERATIONREMARK")
                    .IsUnicode(false);

                entity.Property(e => e.Referenceno)
                    .IsRequired()
                    .HasColumnName("REFERENCENO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ApprovalstatusNavigation)
                    .WithMany(p => p.TblOutwardbankcheque)
                    .HasForeignKey(d => d.Approvalstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_OUTWARDBANKCHEQUE_TBL_APPROVALSTATUS");

                entity.HasOne(d => d.ClearingoptionNavigation)
                    .WithMany(p => p.TblOutwardbankcheque)
                    .HasForeignKey(d => d.Clearingoption)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_OUTWARDBANKCHEQUE_TBL_CLEARINGOPTIONS");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.ToTable("tbl_Product", "Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allowcustomeraccountforcedebit).HasColumnName("ALLOWCUSTOMERACCOUNTFORCEDEBIT");

                entity.Property(e => e.Allowmoratorium).HasColumnName("ALLOWMORATORIUM");

                entity.Property(e => e.Allowoverdrawn).HasColumnName("ALLOWOVERDRAWN");

                entity.Property(e => e.Allowrate).HasColumnName("ALLOWRATE");

                entity.Property(e => e.Allowscheduletypeoverride).HasColumnName("ALLOWSCHEDULETYPEOVERRIDE");

                entity.Property(e => e.Allowtenor).HasColumnName("ALLOWTENOR");

                entity.Property(e => e.Approved).HasColumnName("APPROVED");

                entity.Property(e => e.Approvedby).HasColumnName("APPROVEDBY");

                entity.Property(e => e.Cleanupperiod).HasColumnName("CLEANUPPERIOD");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Completed).HasColumnName("COMPLETED");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Daycountconventionid).HasColumnName("DAYCOUNTCONVENTIONID");

                entity.Property(e => e.Dealclassificationid).HasColumnName("DEALCLASSIFICATIONID");

                entity.Property(e => e.Dealtypeid).HasColumnName("DEALTYPEID");

                entity.Property(e => e.Defaultgraceperiod).HasColumnName("DEFAULTGRACEPERIOD");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.Dormantgl).HasColumnName("DORMANTGL");

                entity.Property(e => e.Equitycontribution).HasColumnName("EQUITYCONTRIBUTION");

                entity.Property(e => e.Expiryperiod).HasColumnName("EXPIRYPERIOD");

                entity.Property(e => e.Interestincomeexpensegl).HasColumnName("INTERESTINCOMEEXPENSEGL");

                entity.Property(e => e.Interestreceivablepayablegl).HasColumnName("INTERESTRECEIVABLEPAYABLEGL");

                entity.Property(e => e.Ismultiplecurency).HasColumnName("ISMULTIPLECURENCY");

                entity.Property(e => e.Lastupdatedby).HasColumnName("LASTUPDATEDBY");

                entity.Property(e => e.Maximumdrawdownduration).HasColumnName("MAXIMUMDRAWDOWNDURATION");

                entity.Property(e => e.Maximumrate).HasColumnName("MAXIMUMRATE");

                entity.Property(e => e.Maximumtenor).HasColumnName("MAXIMUMTENOR");

                entity.Property(e => e.Minimumbalance).HasColumnName("MINIMUMBALANCE");

                entity.Property(e => e.Minimumrate).HasColumnName("MINIMUMRATE");

                entity.Property(e => e.Minimumtenor).HasColumnName("MINIMUMTENOR");

                entity.Property(e => e.Overdrawngl).HasColumnName("OVERDRAWNGL");

                entity.Property(e => e.Premiumdiscountgl).HasColumnName("PREMIUMDISCOUNTGL");

                entity.Property(e => e.Principalbalancegl).HasColumnName("PRINCIPALBALANCEGL");

                entity.Property(e => e.ProductBehaviourid).HasColumnName("PRODUCT_BEHAVIOURID");

                entity.Property(e => e.Productcategoryid).HasColumnName("PRODUCTCATEGORYID");

                entity.Property(e => e.Productclassid).HasColumnName("PRODUCTCLASSID");

                entity.Property(e => e.Productcode)
                    .HasColumnName("PRODUCTCODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Productdescription)
                    .HasColumnName("PRODUCTDESCRIPTION")
                    .HasMaxLength(200);

                entity.Property(e => e.Productid)
                    .HasColumnName("PRODUCTID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Productname)
                    .HasColumnName("PRODUCTNAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Productpriceindexid).HasColumnName("PRODUCTPRICEINDEXID");

                entity.Property(e => e.Productpriceindexspread).HasColumnName("PRODUCTPRICEINDEXSPREAD");

                entity.Property(e => e.Producttypeid).HasColumnName("PRODUCTTYPEID");

                entity.Property(e => e.Scheduletypeid).HasColumnName("SCHEDULETYPEID");

                entity.HasOne(d => d.Producttype)
                    .WithMany(p => p.TblProduct)
                    .HasForeignKey(d => d.Producttypeid)
                    .HasConstraintName("FK_tbl_Product_tbl_BankingProductType");
            });

            modelBuilder.Entity<TblProductCategory>(entity =>
            {
                entity.ToTable("tbl_ProductCategory", "Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Productcategoryid).HasColumnName("PRODUCTCATEGORYID");

                entity.Property(e => e.Productcategoryname)
                    .IsRequired()
                    .HasColumnName("PRODUCTCATEGORYNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblProductGroup>(entity =>
            {
                entity.ToTable("tbl_ProductGroup", "Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Productgroupcode)
                    .IsRequired()
                    .HasColumnName("PRODUCTGROUPCODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Productgroupid)
                    .IsRequired()
                    .HasColumnName("PRODUCTGROUPID")
                    .HasMaxLength(50);

                entity.Property(e => e.Productgroupname)
                    .IsRequired()
                    .HasColumnName("PRODUCTGROUPNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblRegion>(entity =>
            {
                entity.HasKey(e => e.Regionid);

                entity.ToTable("TBL_REGION", "Customer");

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");

                entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");

                entity.Property(e => e.Regionname)
                    .IsRequired()
                    .HasColumnName("REGIONNAME")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblRegion)
                    .HasForeignKey(d => d.Countryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Region_tbl_Country");
            });

            modelBuilder.Entity<TblRetailoperationtype>(entity =>
            {
                entity.HasKey(e => e.Retailoperationid);

                entity.ToTable("TBL_RETAILOPERATIONTYPE", "Retail");

                entity.Property(e => e.Retailoperationid).HasColumnName("RETAILOPERATIONID");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdatedby)
                    .HasColumnName("LASTUPDATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Retailoperationname)
                    .IsRequired()
                    .HasColumnName("RETAILOPERATIONNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblScheduleSimulation>(entity =>
            {
                entity.ToTable("Tbl_ScheduleSimulation", "Credit");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dd).HasColumnName("dd");

                entity.Property(e => e.Eop).HasColumnName("EOP");

                entity.Property(e => e.FirstPayDate).HasColumnType("datetime");

                entity.Property(e => e.FreqOfFee).HasColumnName("freqOfFee");

                entity.Property(e => e.InterestRate).HasColumnName("interestRate");

                entity.Property(e => e.Moratorium).HasColumnName("moratorium");

                entity.Property(e => e.NumOfInstalment).HasColumnName("numOfInstalment");

                entity.Property(e => e.Principal).HasColumnName("principal");

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSector>(entity =>
            {
                entity.HasKey(e => e.Sectorid);

                entity.ToTable("TBL_SECTOR", "Customer");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__tbl_Sect__737584F6E31E5F87")
                    .IsUnique();

                entity.Property(e => e.Sectorid).HasColumnName("SECTORID");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblSensitivitylevel>(entity =>
            {
                entity.ToTable("TBL_SENSITIVITYLEVEL", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .HasColumnName("ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sensitivitylevel)
                    .IsRequired()
                    .HasColumnName("SENSITIVITYLEVEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSingleFundTransfer>(entity =>
            {
                entity.ToTable("tbl_SingleFundTransfer", "Finance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountCr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountDr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.NarrationCr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NarrationDr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostingTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReciepNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TransCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSourceoffunds>(entity =>
            {
                entity.ToTable("TBL_SOURCEOFFUNDS", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("SOURCE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblStaff>(entity =>
            {
                entity.HasKey(e => e.Staffid);

                entity.ToTable("TBL_STAFF", "Customer");

                entity.HasIndex(e => new { e.Staffcode, e.Companyid })
                    .HasName("UQ__tbl_Staf__D83AD8129979FE19")
                    .IsUnique();

                entity.Property(e => e.Staffid)
                    .HasColumnName("STAFFID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(100);

                entity.Property(e => e.Addressofnok)
                    .HasColumnName("ADDRESSOFNOK")
                    .HasMaxLength(100);

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Cityid).HasColumnName("CITYID");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(100);

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Customersensitivitylevel)
                    .HasColumnName("CUSTOMERSENSITIVITYLEVEL")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnName("DATEOFBIRTH")
                    .HasColumnType("date");

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.DepartmentUnitid).HasColumnName("DEPARTMENT_UNITID");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100);

                entity.Property(e => e.Emailofnok)
                    .HasColumnName("EMAILOFNOK")
                    .HasMaxLength(100);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.Genderofnok)
                    .HasColumnName("GENDEROFNOK")
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.Jobtitleid).HasColumnName("JOBTITLEID");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("LASTNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastupdatedby).HasColumnName("LASTUPDATEDBY");

                entity.Property(e => e.Middlename)
                    .HasColumnName("MIDDLENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Misinfoid).HasColumnName("MISINFOID");

                entity.Property(e => e.Nameofnok)
                    .HasColumnName("NAMEOFNOK")
                    .HasMaxLength(100);

                entity.Property(e => e.Nokrelationship)
                    .HasColumnName("NOKRELATIONSHIP")
                    .HasMaxLength(100);

                entity.Property(e => e.NplLimitexceeded).HasColumnName("NPL_LIMITEXCEEDED");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(100);

                entity.Property(e => e.Phoneofnok)
                    .HasColumnName("PHONEOFNOK")
                    .HasMaxLength(100);

                entity.Property(e => e.Rankid).HasColumnName("RANKID");

                entity.Property(e => e.Staffcode)
                    .IsRequired()
                    .HasColumnName("STAFFCODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Stateid).HasColumnName("STATEID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblStaff)
                    .HasForeignKey(d => d.Cityid)
                    .HasConstraintName("FK_tbl_Staff_tbl_City");

                entity.HasOne(d => d.Jobtitle)
                    .WithMany(p => p.TblStaff)
                    .HasForeignKey(d => d.Jobtitleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Staff_tbl_Staff_JobTitle");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.TblStaff)
                    .HasForeignKey(d => d.Rankid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Staff_tbl_Staff_Rank");
            });

            modelBuilder.Entity<TblStaffInfo>(entity =>
            {
                entity.ToTable("tbl_StaffInfo", "Credit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddrOfNok)
                    .HasColumnName("AddrOfNOK")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Age).HasColumnType("datetime");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CoyId)
                    .HasColumnName("CoyID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailOfNok)
                    .HasColumnName("EmailOfNOK")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GenderOfNok)
                    .HasColumnName("GenderOfNOK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MisCode)
                    .HasColumnName("MIsCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfNok)
                    .HasColumnName("NameOfNOK")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PcCode)
                    .HasColumnName("pcCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneOfNok)
                    .HasColumnName("PhoneOfNOK")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rank)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RelationShip)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StaffName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Staffsignature).HasColumnType("image");

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblStaffInformation>(entity =>
            {
                entity.ToTable("tbl_StaffInformation", "GeneralSetup");

                entity.Property(e => e.BranchLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageData).HasColumnType("image");

                entity.Property(e => e.ImageTitle).HasColumnName("imageTitle");
            });

            modelBuilder.Entity<TblStaffjobtitle>(entity =>
            {
                entity.HasKey(e => e.Jobtitleid);

                entity.ToTable("TBL_STAFFJOBTITLE", "Customer");

                entity.HasIndex(e => new { e.Companyid, e.Jobtitlename })
                    .HasName("IX_tbl_JobTitle")
                    .IsUnique();

                entity.Property(e => e.Jobtitleid).HasColumnName("JOBTITLEID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Jobtitlename)
                    .IsRequired()
                    .HasColumnName("JOBTITLENAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblStaffrank>(entity =>
            {
                entity.HasKey(e => e.Rankid);

                entity.ToTable("TBL_STAFFRANK", "Customer");

                entity.Property(e => e.Rankid).HasColumnName("RANKID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Rankcode)
                    .HasColumnName("RANKCODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Rankname)
                    .IsRequired()
                    .HasColumnName("RANKNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblStampcharge>(entity =>
            {
                entity.ToTable("TBL_STAMPCHARGE", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Charge).HasColumnName("CHARGE");

                entity.Property(e => e.Chartofaccountid).HasColumnName("CHARTOFACCOUNTID");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("date");

                entity.HasOne(d => d.Chartofaccount)
                    .WithMany(p => p.TblStampcharge)
                    .HasForeignKey(d => d.Chartofaccountid)
                    .HasConstraintName("FK_TBL_Finance_tbl_FinanceChartOfAccount");
            });

            modelBuilder.Entity<TblState>(entity =>
            {
                entity.HasKey(e => e.Stateid);

                entity.ToTable("TBL_STATE", "Customer");

                entity.HasIndex(e => e.Statename)
                    .HasName("UQ__tbl_Stat__737584F619751F56")
                    .IsUnique();

                entity.Property(e => e.Stateid).HasColumnName("STATEID");

                entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lgaid).HasColumnName("LGAID");

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");

                entity.Property(e => e.Statename)
                    .IsRequired()
                    .HasColumnName("STATENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblState)
                    .HasForeignKey(d => d.Countryid)
                    .HasConstraintName("FK_TBL_STATE_TBL_COUNTRY");

                entity.HasOne(d => d.Lga)
                    .WithMany(p => p.TblState)
                    .HasForeignKey(d => d.Lgaid)
                    .HasConstraintName("FK_TBL_STATE_TBL_STATE_AND_LGA");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.TblState)
                    .HasForeignKey(d => d.Regionid)
                    .HasConstraintName("FK_tbl_State_tbl_Region");
            });

            modelBuilder.Entity<TblStateandlga>(entity =>
            {
                entity.ToTable("TBL_STATEANDLGA", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lga)
                    .IsRequired()
                    .HasColumnName("LGA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("STATE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Stateid).HasColumnName("STATEID");
            });

            modelBuilder.Entity<TblSubsector>(entity =>
            {
                entity.HasKey(e => e.Subsectorid);

                entity.ToTable("TBL_SUBSECTOR", "Customer");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__tbl_Sub___737584F6F3BA5E6B")
                    .IsUnique();

                entity.Property(e => e.Subsectorid).HasColumnName("SUBSECTORID");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Sectorid).HasColumnName("SECTORID");
            });

            modelBuilder.Entity<TblSystemnarration>(entity =>
            {
                entity.ToTable("TBL_SYSTEMNARRATION", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("date");

                entity.Property(e => e.Isdefault).HasColumnName("ISDEFAULT");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("TEXT")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTellercloselimitsetup>(entity =>
            {
                entity.HasKey(e => e.Tellercloselimitid);

                entity.ToTable("TBL_TELLERCLOSELIMITSETUP", "Retail");

                entity.Property(e => e.Tellercloselimitid).HasColumnName("TELLERCLOSELIMITID");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdatedby)
                    .HasColumnName("LASTUPDATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Retailoperationid).HasColumnName("RETAILOPERATIONID");

                entity.HasOne(d => d.Retailoperation)
                    .WithMany(p => p.TblTellercloselimitsetup)
                    .HasForeignKey(d => d.Retailoperationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TELLERCLOSELIMITSETUP_TBL_RETAILOPERATIONTYPE");
            });

            modelBuilder.Entity<TblTellerlimit>(entity =>
            {
                entity.ToTable("TBL_TELLERLIMIT", "Retail");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Isdelete).HasColumnName("ISDELETE");

                entity.Property(e => e.Maxamount).HasColumnName("MAXAMOUNT");

                entity.Property(e => e.Minamount).HasColumnName("MINAMOUNT");

                entity.Property(e => e.Operationname)
                    .HasColumnName("OPERATIONNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Operationtypeid).HasColumnName("OPERATIONTYPEID");

                entity.HasOne(d => d.Operationtype)
                    .WithMany(p => p.TblTellerlimit)
                    .HasForeignKey(d => d.Operationtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TELLERLIMIT_TBL_OPERATIONTYPE");
            });

            modelBuilder.Entity<TblTellerlogin>(entity =>
            {
                entity.ToTable("TBL_TELLERLOGIN", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountbalance)
                    .HasColumnName("ACCOUNTBALANCE")
                    .HasColumnType("money");

                entity.Property(e => e.Accountid)
                    .HasColumnName("ACCOUNTID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Assignuser)
                    .HasColumnName("ASSIGNUSER")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Branchid)
                    .HasColumnName("BRANCHID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Closingbalance)
                    .HasColumnName("CLOSINGBALANCE")
                    .HasColumnType("money");

                entity.Property(e => e.Companyid)
                    .HasColumnName("COMPANYID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Ledgername)
                    .IsRequired()
                    .HasColumnName("LEDGERNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tellerlimitid).HasColumnName("TELLERLIMITID");

                entity.Property(e => e.Tellerlogindate)
                    .HasColumnName("TELLERLOGINDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tellerlogintime)
                    .HasColumnName("TELLERLOGINTIME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tellerno)
                    .HasColumnName("TELLERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tellersetupid).HasColumnName("TELLERSETUPID");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTellersetup>(entity =>
            {
                entity.ToTable("TBL_TELLERSETUP", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("date");

                entity.Property(e => e.Isdelete).HasColumnName("ISDELETE");

                entity.Property(e => e.Staffinformationid)
                    .HasColumnName("STAFFINFORMATIONID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tellertillaccount)
                    .HasColumnName("TELLERTILLACCOUNT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tillaccountnumber)
                    .IsRequired()
                    .HasColumnName("TILLACCOUNTNUMBER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tilllimitamount).HasColumnName("TILLLIMITAMOUNT");

                entity.Property(e => e.Tilllimitid).HasColumnName("TILLLIMITID");

                entity.Property(e => e.Tillmappingid).HasColumnName("TILLMAPPINGID");

                entity.Property(e => e.Tillname)
                    .IsRequired()
                    .HasColumnName("TILLNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tilluser)
                    .IsRequired()
                    .HasColumnName("TILLUSER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Tilllimit)
                    .WithMany(p => p.TblTellersetup)
                    .HasForeignKey(d => d.Tilllimitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TELLERSETUP_TBL_TILLIMIT");

                entity.HasOne(d => d.Tillmapping)
                    .WithMany(p => p.TblTellersetup)
                    .HasForeignKey(d => d.Tillmappingid)
                    .HasConstraintName("FK_TBL_TELLERSETUP_TBL_TILLMAPPING");
            });

            modelBuilder.Entity<TblTempBankingUpdateSchedule>(entity =>
            {
                entity.ToTable("tbl_TempBankingUpdateSchedule", "Credit");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CoyClass)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentAcct)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndBalance).HasColumnName("endBalance");

                entity.Property(e => e.NextPayDay).HasColumnType("datetime");

                entity.Property(e => e.PdTypeId)
                    .HasColumnName("pdTypeID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAcctNo)
                    .HasColumnName("productAcctNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .HasColumnName("ref")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTilldefinition>(entity =>
            {
                entity.ToTable("TBL_TILLDEFINITION", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateupdated)
                    .HasColumnName("DATEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Tellername)
                    .IsRequired()
                    .HasColumnName("TELLERNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedby)
                    .HasColumnName("UPDATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTillimit>(entity =>
            {
                entity.ToTable("TBL_TILLIMIT", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("date");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Ledgeraccount)
                    .IsRequired()
                    .HasColumnName("LEDGERACCOUNT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tillfunction)
                    .IsRequired()
                    .HasColumnName("TILLFUNCTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tillfunctionid).HasColumnName("TILLFUNCTIONID");

                entity.Property(e => e.Tillmappingid).HasColumnName("TILLMAPPINGID");

                entity.Property(e => e.Tillname)
                    .IsRequired()
                    .HasColumnName("TILLNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.TillfunctionNavigation)
                    .WithMany(p => p.TblTillimit)
                    .HasForeignKey(d => d.Tillfunctionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TILLIMIT_TBL_TILLTFUNCTION");

                entity.HasOne(d => d.Tillmapping)
                    .WithMany(p => p.TblTillimit)
                    .HasForeignKey(d => d.Tillmappingid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TILLIMIT_TBL_TILLMAPPING");
            });

            modelBuilder.Entity<TblTilllimitsetup>(entity =>
            {
                entity.HasKey(e => e.Tillid);

                entity.ToTable("TBL_TILLLIMITSETUP", "Retail");

                entity.Property(e => e.Tillid).HasColumnName("TILLID");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnName("DATETIMEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdatedby)
                    .HasColumnName("LASTUPDATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Limitamount)
                    .HasColumnName("LIMITAMOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Telleraccountid)
                    .IsRequired()
                    .HasColumnName("TELLERACCOUNTID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tilluserid).HasColumnName("TILLUSERID");
            });

            modelBuilder.Entity<TblTillmapping>(entity =>
            {
                entity.ToTable("TBL_TILLMAPPING", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountid)
                    .IsRequired()
                    .HasColumnName("ACCOUNTID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Chartofaccountid).HasColumnName("CHARTOFACCOUNTID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateupdated)
                    .HasColumnName("DATEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Tilldefinationid).HasColumnName("TILLDEFINATIONID");

                entity.Property(e => e.Tilldefinationname)
                    .IsRequired()
                    .HasColumnName("TILLDEFINATIONNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tilltypeid).HasColumnName("TILLTYPEID");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("UPDATEDBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Tilldefination)
                    .WithMany(p => p.TblTillmapping)
                    .HasForeignKey(d => d.Tilldefinationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TILLMAPPING_TBL_TILLDEFINITION");

                entity.HasOne(d => d.Tilltype)
                    .WithMany(p => p.TblTillmapping)
                    .HasForeignKey(d => d.Tilltypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_TILLMAPPING_TBL_TILLTYPE");
            });

            modelBuilder.Entity<TblTilltfunction>(entity =>
            {
                entity.ToTable("TBL_TILLTFUNCTION", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Functioncode).HasColumnName("FUNCTIONCODE");

                entity.Property(e => e.Tillfunction)
                    .IsRequired()
                    .HasColumnName("TILLFUNCTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTilltype>(entity =>
            {
                entity.ToTable("TBL_TILLTYPE", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTitle>(entity =>
            {
                entity.ToTable("TBL_TITLE", "Customer");

                entity.HasIndex(e => e.Title)
                    .HasName("IX_TBL_TITLE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTransfercharge>(entity =>
            {
                entity.HasKey(e => e.Transferchargeid);

                entity.ToTable("TBL_TRANSFERCHARGE", "Retail");

                entity.Property(e => e.Transferchargeid).HasColumnName("TRANSFERCHARGEID");

                entity.Property(e => e.Amounttocharge)
                    .HasColumnName("AMOUNTTOCHARGE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Branchid).HasColumnName("BRANCHID");

                entity.Property(e => e.Chartofaccountid).HasColumnName("CHARTOFACCOUNTID");

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datetimecreated)
                    .HasColumnName("DATETIMECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetimedeleted)
                    .HasColumnName("DATETIMEDELETED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Deletedby)
                    .HasColumnName("DELETEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Maxamount)
                    .HasColumnName("MAXAMOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Minamount)
                    .HasColumnName("MINAMOUNT")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblTreasurySecurity>(entity =>
            {
                entity.ToTable("tbl_TreasurySecurity", "Product");

                entity.Property(e => e.PdCode)
                    .HasColumnName("pdCode")
                    .HasMaxLength(50);

                entity.Property(e => e.PdSecurity)
                    .HasColumnName("pdSecurity")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblTreasuryTt>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("tbl_TreasuryTT", "Treasury");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("ApplicationID")
                    .HasMaxLength(255);

                entity.Property(e => e.BatchRef).HasMaxLength(255);

                entity.Property(e => e.CVolume).HasColumnName("cVolume");

                entity.Property(e => e.CpId)
                    .HasColumnName("cpID")
                    .HasMaxLength(255);

                entity.Property(e => e.CustCode).HasMaxLength(255);

                entity.Property(e => e.DVolume).HasColumnName("dVolume");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FormNo).HasMaxLength(255);

                entity.Property(e => e.GlaccountId)
                    .HasColumnName("GLAccountID")
                    .HasMaxLength(255);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.ProductCode).HasMaxLength(255);

                entity.Property(e => e.Ref).HasMaxLength(255);

                entity.Property(e => e.Show).HasColumnName("show");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<TsCreditType>(entity =>
            {
                entity.HasKey(e => e.CreditTypeId);

                entity.ToTable("ts_CreditType", "Credit");

                entity.Property(e => e.CreditTypeId).HasColumnName("CreditTypeID");

                entity.Property(e => e.BranchId)
                    .HasColumnName("branchID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoyId)
                    .HasColumnName("CoyID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Lastupdate).HasColumnType("datetime");

                entity.Property(e => e.PdCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TsFinanceCurrentDate>(entity =>
            {
                entity.ToTable("ts_FinanceCurrentDate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentDate).HasColumnType("datetime");
            });

            //modelBuilder.Entity<TblDesignation>(entity =>
            //{
            //    entity.ToTable("tbl_Designation", "GeneralSetup");

            //    entity.Property(e => e.Designation)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);
            //});
        }
    }
}
