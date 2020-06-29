using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TheCoreBanking.Customer.Data.ProcedureAndFunctionDTO;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TheCoreBankingCustomerContext : DbContext
    {
        public virtual DbSet<TblAccountalertmedium> TblAccountalertmedium { get; set; }
        public virtual DbSet<TblAccountbankingservice> TblAccountbankingservice { get; set; }
        public virtual DbSet<TblAccountcardtype> TblAccountcardtype { get; set; }
        public virtual DbSet<TblAccountchequeconfirmation> TblAccountchequeconfirmation { get; set; }
        public virtual DbSet<TblAccountreferee> TblAccountreferee { get; set; }
        public virtual DbSet<TblAccountstmntfreq> TblAccountstmntfreq { get; set; }
        public virtual DbSet<TblAccountstmntmedium> TblAccountstmntmedium { get; set; }
        public virtual DbSet<TblAnnualincome> TblAnnualincome { get; set; }
        public virtual DbSet<TblBank> TblBank { get; set; }
        public virtual DbSet<TblBankaccounttype> TblBankaccounttype { get; set; }
        public virtual DbSet<TblBranch> TblBranch { get; set; }
        public virtual DbSet<TblBusinesscategory> TblBusinesscategory { get; set; }
        public virtual DbSet<TblCasa> TblCasa { get; set; }
        public virtual DbSet<TblCasaaccountstatus> TblCasaaccountstatus { get; set; }
        public virtual DbSet<TblCasaproductconversiontracker> TblCasaproductconversiontracker { get; set; }
        public virtual DbSet<TblCasafreeze> TblCasafreeze { get; set; }
        public virtual DbSet<TblCasapostnostatus> TblCasapostnostatus { get; set; }
        public virtual DbSet<TblCity> TblCity { get; set; }
        public virtual DbSet<TblCompany> TblCompany { get; set; }
        public virtual DbSet<TblCompanyclass> TblCompanyclass { get; set; }
        public virtual DbSet<TblCompanytype> TblCompanytype { get; set; }
        public virtual DbSet<TblCountry> TblCountry { get; set; }
        public virtual DbSet<TblCurrency> TblCurrency { get; set; }
        public virtual DbSet<TblCustomer> TblCustomer { get; set; }
        public virtual DbSet<TblCustomercustomfieldlist> TblCustomercustomfieldlist { get; set; }
        public virtual DbSet<TblCustomercustomfieldoptions> TblCustomercustomfieldoptions { get; set; }
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
        public virtual DbSet<TblGender> TblGender { get; set; }
        public virtual DbSet<TblIndustry> TblIndustry { get; set; }
        public virtual DbSet<TblInsertcustomerprofile> TblInsertcustomerprofile { get; set; }
        public virtual DbSet<TblInstitutiontype> TblInstitutiontype { get; set; }
        public virtual DbSet<TblKycdocumenttype> TblKycdocumenttype { get; set; }
        public virtual DbSet<TblKycitem> TblKycitem { get; set; }
        public virtual DbSet<TblKycitemaction> TblKycitemaction { get; set; }
        public virtual DbSet<TblMaintenanceaccountdetails> TblMaintenanceaccountdetails { get; set; }
        public virtual DbSet<TblMaintenancetrack> TblMaintenancetrack { get; set; }
        public virtual DbSet<TblMandate> TblMandate { get; set; }
        public virtual DbSet<TblMaritalstatus> TblMaritalstatus { get; set; }
        public virtual DbSet<TblModeofidentification> TblModeofidentification { get; set; }
        public virtual DbSet<TblNatureofbusiness> TblNatureofbusiness { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }
        public virtual DbSet<TblRegion> TblRegion { get; set; }
        public virtual DbSet<TblSector> TblSector { get; set; }
        public virtual DbSet<TblSensitivitylevel> TblSensitivitylevel { get; set; }
        public virtual DbSet<TblSourceoffunds> TblSourceoffunds { get; set; }
        public virtual DbSet<TblStaff> TblStaff { get; set; }
        public virtual DbSet<TblStaffjobtitle> TblStaffjobtitle { get; set; }
        public virtual DbSet<TblStaffrank> TblStaffrank { get; set; }
        public virtual DbSet<TblState> TblState { get; set; }
        public virtual DbSet<TblStateandlga> TblStateandlga { get; set; }
        public virtual DbSet<TblSubsector> TblSubsector { get; set; }
        public virtual DbSet<TblTitle> TblTitle { get; set; }
        public virtual DbSet<TblAccountfreeze> TblAccountfreeze { get; set; }
        public virtual DbSet<TblBankingcasa> TblBankingcasa { get; set; }
        public virtual DbSet<TblBankingcustomers> TblBankingcustomers { get; set; }
        public virtual DbSet<TblFreezedatetype> TblFreezedatetype { get; set; }
        public virtual DbSet<TblFreezereasontype> TblFreezereasontype { get; set; }
        public virtual DbSet<TblFreezetransactionlist> TblFreezetransactionlist { get; set; }
        public virtual DbSet<TblFreezetype> TblFreezetype { get; set; }
        public virtual DbSet<TblDesignation> TblDesignation { get; set; }
        public virtual DbSet<TblBankingProductFeesListExtraMaintenance> TblBankingProductFeesListExtraMaintenance { get; set; }
        public virtual DbSet<ChargesPending> ChargesPendings { get; set; }
        public virtual DbSet<TblAccountclosure> TblAccountclosure { get; set; }
        public virtual DbSet<TblFinanceChartOfAccount> TblFinanceChartOfAccount { get; set; }
        public virtual DbSet<TblStampcharge> TblStampcharge { get; set; }
        public virtual DbSet<TblStaffInformation> TblStaffInformation { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.

#if DEBUG
               // optionsBuilder.UseSqlServer(@"Server=DESKTOP-5VJ567N\FINTRAKSQL;Database=TheCoreBanking;User Id=sa;Password=sqluser10$;");

               optionsBuilder.UseSqlServer(@"Server=fintraksqlmmbs.database.windows.net;Database=TheCoreBankingAzure;User Id=fintrak;Password=Password20$;");

#else
               
                 optionsBuilder.UseSqlServer(@"Server=fintraksqlmmbs.database.windows.net;Database=TheCoreBankingAzure;User Id=fintrak;Password=Password20$;");
               
#endif
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Isdisapproved).HasColumnName("ISDISAPPROVED");

                entity.Property(e => e.Approvalstatus).HasColumnName("APPROVALSTATUS");

                entity.Property(e => e.Copyfileid).HasColumnName("COPYFILEID");

                entity.Property(e => e.Isnewlycreated).HasColumnName("ISNEWLYCREATED");

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

                entity.Property(e => e.Customercode).HasColumnName("CUSTOMERCODE");

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

                /* entity.HasOne(d => d.Accountstatus)
                     .WithMany(p => p.TblCasa)
                     .HasForeignKey(d => d.Accountstatusid)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_TBL_CASA_TBL_CASAACCOUNTSTATUS");

                 entity.HasOne(d => d.Customer)
                     .WithMany(p => p.TblCasa)
                     .HasForeignKey(d => d.Customerid)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_tbl_CASA_tbl_Customer");

                   entity.HasOne(d => d.Product)
                      .WithMany(p => p.TblCasa);
                  .HasForeignKey(d => d.Productid)
                  .HasConstraintName("FK_TBL_Product_tbl_Product");*/
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

                entity.Property(e => e.Bvn)
                   .HasColumnName("BVN")
                   .HasMaxLength(50);
            
                entity.Property(e => e.Workstate).HasColumnName("WORKSTATE");

                entity.HasOne(d => d.Annualincome)
                .WithMany(p => p.TblCustomer)
                .HasForeignKey(d => d.Annualincomeid)
                .HasConstraintName("FK_TBL_CUSTOMERs_TBL_ANNUALINCOME");

                entity.HasOne(d => d.Bankaccountype)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Bankaccountypeid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_BANKACCOUNTTYPE");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Bankid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_BANK");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Branchid)
                    .HasConstraintName("FK_tbl_Customers_tbl_Branch");

                entity.HasOne(d => d.Businesscategory)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Businesscategoryid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_BUSINESSCATEGORY");

                entity.HasOne(d => d.Customeraccounttype)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Customeraccounttypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_CUSTOMERACCOUNTTYPE");

                entity.HasOne(d => d.Customersensitivitylevel)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Customersensitivitylevelid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_SENSITIVITYLEVEL");

                entity.HasOne(d => d.EmploymentstatusNavigation)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Employmentstatus)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_EMPLOYMENTTYPE");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.TblCustomerGender)
                    .HasForeignKey(d => d.Genderid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_GENDER");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Industryid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_INDUSTRY");

                entity.HasOne(d => d.Institutiontype)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Institutiontypeid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_INSTITUTIONTYPE");

                entity.HasOne(d => d.Maritalstatus)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Maritalstatusid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_MARITAL_STATUS");

                entity.HasOne(d => d.Modeofidentification)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Modeofidentificationid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_MODEOFIDENTIFICATION");

                entity.HasOne(d => d.Nokgender)
                    .WithMany(p => p.TblCustomerNokgender)
                    .HasForeignKey(d => d.Nokgenderid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_GENDER1");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Regionid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_REGION");

                entity.HasOne(d => d.Relationshipofficer)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Relationshipofficerid)
                    .HasConstraintName("FK__TBL_STAFF__TBL_CUSTOMERs");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Sectorid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_SECTOR");

                entity.HasOne(d => d.Sourceoffund)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Sourceoffundid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_SOURCEOFFUNDS");

                entity.HasOne(d => d.Stateoforigin)
                    .WithMany(p => p.TblCustomerStateoforigin)
                    .HasForeignKey(d => d.Stateoforiginid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_STATE1");

                entity.HasOne(d => d.Stateoriginlga)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Stateoriginlgaid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_STATEANDLGA");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Titleid)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_TITLE");

                entity.HasOne(d => d.WorkcountryNavigation)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.Workcountry)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_COUNTRY");

                entity.HasOne(d => d.WorkstateNavigation)
                    .WithMany(p => p.TblCustomerWorkstateNavigation)
                    .HasForeignKey(d => d.Workstate)
                    .HasConstraintName("FK_TBL_CUSTOMERs_TBL_STATE");
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

            modelBuilder.Entity<TblGender>(entity =>
            {
                entity.ToTable("TBL_GENDER", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nchar(10)");
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

                entity.Property(e => e.Isapproved)
                    .HasColumnName("ISAPPROVED");

                entity.Property(e => e.Isdisapproved)
                    .HasColumnName("ISDISAPPROVED");

                entity.Property(e => e.Approvalstatus)
                    .HasColumnName("APPROVALSTATUS");

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

                /*entity.HasOne(d => d.Productcategory)
                    .WithMany(p => p.TblProduct)
                    .HasPrincipalKey(p => p.Productcategoryid)
                    .HasForeignKey(d => d.Productcategoryid)
                    .HasConstraintName("FK_tbl_Product_tbl_Product");

                entity.HasOne(d => d.Producttype)
                    .WithMany(p => p.TblProduct)
                    .HasForeignKey(d => d.Producttypeid)
                    .HasConstraintName("FK_tbl_Product_tbl_BankingProductType");*/
            });

            modelBuilder.Entity<TblAccountfreeze>(entity =>
            {
                entity.ToTable("TBL_ACCOUNTFREEZE", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AttachedDocumntId).HasColumnName("AttachedDocumntID");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateTypeId).HasColumnName("DateTypeID");

                entity.Property(e => e.DocAttachment)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FreezeCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FreezeReason).IsUnicode(false);

                entity.Property(e => e.FreezeReason2).IsUnicode(false);

                entity.Property(e => e.FreezeTypeId).HasColumnName("FreezeTypeID");

                entity.Property(e => e.IsReversed).HasColumnName("isReversed");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionToPreventId).HasColumnName("TransactionToPreventID");

                entity.HasOne(d => d.DateType)
                    .WithMany(p => p.TblAccountfreeze)
                    .HasForeignKey(d => d.DateTypeId)
                    .HasConstraintName("FK_TBL_ACCOUNTFREEZE_TBL_FREEZEDATETYPE");

                entity.HasOne(d => d.FreezeType)
                    .WithMany(p => p.TblAccountfreeze)
                    .HasForeignKey(d => d.FreezeTypeId)
                    .HasConstraintName("FK_TBL_ACCOUNTFREEZE_TBL_FreezeType");

                entity.HasOne(d => d.TransactionToPrevent)
                    .WithMany(p => p.TblAccountfreeze)
                    .HasForeignKey(d => d.TransactionToPreventId)
                    .HasConstraintName("FK_TBL_ACCOUNTFREEZE_TBL_FREEZETRANSACTIONLIST");
            });

            modelBuilder.Entity<TblBankingcasa>(entity =>
            {
                entity.ToTable("TBL_BANKINGCASA", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CotacctAmt).HasColumnName("COTAcctAmt");

                entity.Property(e => e.CotcreatedBy)
                    .HasColumnName("COTCreatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cotdate)
                    .HasColumnName("COTDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Deposit).HasColumnType("money");

                entity.Property(e => e.EffectDate).HasColumnType("datetime");

                entity.Property(e => e.Ib).HasColumnName("IB");

                entity.Property(e => e.Interest).HasColumnType("money");

                entity.Property(e => e.LastCreditDate).HasColumnType("datetime");

                entity.Property(e => e.LastDebitDate).HasColumnType("datetime");

                entity.Property(e => e.LedgerBalance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Miscode)
                    .HasColumnName("MISCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NubanAccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Od)
                    .HasColumnName("OD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Odamount)
                    .HasColumnName("ODAmount")
                    .HasColumnType("money");

                entity.Property(e => e.Odexpiry)
                    .HasColumnName("ODExpiry")
                    .HasColumnType("datetime");

                entity.Property(e => e.OdinterestRate)
                    .HasColumnName("ODInterestRate")
                    .HasColumnType("money");

                entity.Property(e => e.Officer1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Officer2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldAccountNuber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldProductAcctNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldProductAcctNo1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldProductAcctNo2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldProductAcctNo3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.Pccode1)
                    .HasColumnName("PCCode1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pccode2)
                    .HasColumnName("PCCode2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PdId).HasColumnName("PdID");

                entity.Property(e => e.Pnc).HasColumnName("PNC");

                entity.Property(e => e.Pnd).HasColumnName("PND");

                entity.Property(e => e.ProductAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sbumis)
                    .HasColumnName("SBUMIS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sms).HasColumnName("SMS");

                entity.Property(e => e.TerminalDate).HasColumnType("datetime");

                entity.Property(e => e.Tod).HasColumnName("TOD");

                entity.Property(e => e.Todexpiry)
                    .HasColumnName("TODExpiry")
                    .HasColumnType("datetime");

                entity.Property(e => e.Todrate)
                    .HasColumnName("TODRate")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblBankingcustomers>(entity =>
            {
                entity.ToTable("TBL_BANKINGCUSTOMERS", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AnnualTurnOver)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bank)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasColumnName("branch")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ccategory)
                    .HasColumnName("CCategory")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ccdate)
                    .HasColumnName("CCDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ccocontact)
                    .HasColumnName("CCOContact")
                    .IsUnicode(false);

                entity.Property(e => e.Ccode)
                    .HasColumnName("CCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ccoi)
                    .HasColumnName("CCOI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CcontactMeans)
                    .HasColumnName("CContactMeans")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ccoresidence)
                    .HasColumnName("CCOResidence")
                    .IsUnicode(false);

                entity.Property(e => e.Cdob)
                    .HasColumnName("CDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.CemployAddress)
                    .HasColumnName("CEmployAddress")
                    .IsUnicode(false);

                entity.Property(e => e.CemployCountry)
                    .HasColumnName("CEmployCountry")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CemployState)
                    .HasColumnName("CEmployState")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationDate).HasColumnType("datetime");

                entity.Property(e => e.Cfname)
                    .HasColumnName("CFName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Cgender)
                    .HasColumnName("CGender")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cguardian)
                    .HasColumnName("CGuardian")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChildDob)
                    .HasColumnName("ChildDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Chphone)
                    .HasColumnName("CHPhone")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CmaidenName)
                    .HasColumnName("CMaidenName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CmodeofId)
                    .HasColumnName("CModeofID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CmodeofIddate)
                    .HasColumnName("CModeofIDDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cmphone)
                    .HasColumnName("CMphone")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cmstatus)
                    .HasColumnName("CMStatus")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cname)
                    .HasColumnName("CName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Cnbusiness)
                    .HasColumnName("CNBusiness")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cnob)
                    .HasColumnName("CNOB")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Cnoemployer)
                    .HasColumnName("CNOEmployer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cnokfname)
                    .HasColumnName("CNOKFName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cnokphone)
                    .HasColumnName("CNOKPhone")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cnoksname)
                    .HasColumnName("CNOKSName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Coccupation)
                    .HasColumnName("COccupation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CofPhone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CorporateBizCategory)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CorrespondenceAddr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CoyWebsite)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CpType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cpacity)
                    .HasColumnName("CPACity")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cpanationality)
                    .HasColumnName("CPANationality")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cpastate)
                    .HasColumnName("CPAState")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cpemail)
                    .HasColumnName("CPEmail")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cpob)
                    .HasColumnName("CPOB")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cpobox)
                    .HasColumnName("CPOBox")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cracountry)
                    .HasColumnName("CRACountry")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Crazip)
                    .HasColumnName("CRAZip")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreditRating)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Crelationship)
                    .HasColumnName("CRelationship")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Csector)
                    .HasColumnName("CSector")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Csname)
                    .HasColumnName("CSName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ctarget)
                    .HasColumnName("CTarget")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ctid)
                    .HasColumnName("CTID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ctitle)
                    .HasColumnName("CTitle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ctname)
                    .HasColumnName("CTName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CusTypeS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPic)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSign)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerThumb)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateAccountOpened).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("date");

                entity.Property(e => e.EducationLevel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployDate).HasColumnType("datetime");

                entity.Property(e => e.EmploymentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedIncome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Field1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field10)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field11)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field12)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field13)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field14)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field15)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field16)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field17)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field18)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field19)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field20)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field6)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field7)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field8)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Field9)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FingerPrintId)
                    .HasColumnName("FingerPrintID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstChild)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GeoRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuardianAddr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GuardianPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeTown)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IndAcctsWithBanks).IsUnicode(false);

                entity.Property(e => e.IndFund)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IssueAuthority)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IssuePlace)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Lga)
                    .HasColumnName("LGA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Miscode)
                    .HasColumnName("MISCODE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Misstaff)
                    .HasColumnName("MISStaff")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NokGender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nokaddress)
                    .HasColumnName("NOKaddress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nokdob)
                    .HasColumnName("NOKDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nokemail)
                    .HasColumnName("NOKemail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermitNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pfacustomer).HasColumnName("PFAcustomer");

                entity.Property(e => e.PrevCreditRating)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousEmployer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RcparentBody)
                    .HasColumnName("RCParentBody")
                    .IsUnicode(false);

                entity.Property(e => e.RcrelatedCoy)
                    .HasColumnName("RCRelatedCoy")
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredOffice)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Scumol)
                    .HasColumnName("SCUMOL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Spouse)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SpouseEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpousePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WedMonth)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFreezedatetype>(entity =>
            {
                entity.ToTable("TBL_FREEZEDATETYPE", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblFreezereasontype>(entity =>
            {
                entity.ToTable("TBL_FREEZEREASONTYPE", "Customer");

                entity.Property(e => e.Reason).HasColumnType("text");
            });

            modelBuilder.Entity<TblFreezetransactionlist>(entity =>
            {
                entity.ToTable("TBL_FREEZETRANSACTIONLIST", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.FreezeTransaction).IsUnicode(false);
            });

            modelBuilder.Entity<TblFreezetype>(entity =>
            {
                entity.ToTable("TBL_FREEZETYPE", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.FreezeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDesignation>(entity =>
            {
                entity.ToTable("tbl_Designation", "GeneralSetup");

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankingProductFeesListExtraMaintenance>(entity =>
            {
                entity.ToTable("tbl_BankingProductFeesListExtraMaintenance", "Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdditionStatus).HasColumnName("additionStatus");

                entity.Property(e => e.Casaaccountid).HasColumnName("CASAACCOUNTID");

                entity.Property(e => e.PdFeesId).HasColumnName("pdFeesID");

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Isdisapproved).HasColumnName("ISDISAPPROVED");

                entity.Property(e => e.Approvalstatus).HasColumnName("APPROVALSTATUS");

                entity.Property(e => e.Copyfileid).HasColumnName("COPYFILEID");

                entity.Property(e => e.Isnewlycreated).HasColumnName("ISNEWLYCREATED");

                entity.Property(e => e.Deleteflag).HasColumnName("DELETEFLAG");

                entity.Property(e => e.PdFeesName)
                    .HasColumnName("pdFeesName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PdId).HasColumnName("pdID");

                entity.Property(e => e.PdRate).HasColumnName("pdRate");

                entity.HasOne(d => d.Casaaccount)
                   .WithMany(p => p.TblBankingProductFeesListExtraMaintenance)
                   .HasForeignKey(d => d.Casaaccountid)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_TBL_CASA_TBL_CASAACCOUNTID");
            });

            modelBuilder.Entity<TblAccountclosure>(entity =>
            {
                entity.ToTable("TBL_ACCOUNTCLOSURE", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountnumber)
                    .IsRequired()
                    .HasColumnName("ACCOUNTNUMBER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amountpayable)
                    .HasColumnName("AMOUNTPAYABLE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Approved).HasColumnName("APPROVED");

                entity.Property(e => e.Approvedby)
                    .HasColumnName("APPROVEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branchcode)
                    .HasColumnName("BRANCHCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charges)
                    .HasColumnName("CHARGES")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Companycode)
                    .HasColumnName("COMPANYCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cotamount)
                    .HasColumnName("COTAMOUNT")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Creditaccount)
                    .HasColumnName("CREDITACCOUNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateapproved)
                    .HasColumnName("DATEAPPROVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Disapproved).HasColumnName("DISAPPROVED");

                entity.Property(e => e.Interestamount)
                    .HasColumnName("INTERESTAMOUNT")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Operationid).HasColumnName("OPERATIONID");

                entity.Property(e => e.Reference)
                    .HasColumnName("REFERENCE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Smsamount)
                    .HasColumnName("SMSAMOUNT")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");
            });
            modelBuilder.Entity<TblFinanceChartOfAccount>(entity =>
            {
                entity.ToTable("tbl_FinanceChartOfAccount", "Finance");

                entity.Property(e => e.AccountCategoryId).HasColumnName("AccountCategoryID");

                entity.Property(e => e.AccountGroupId).HasColumnName("AccountGroupID");

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasColumnName("AccountID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(500)
                    .HasColumnName("AccountName")
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
            modelBuilder.Entity<TblStampcharge>(entity =>
            {
                entity.ToTable("TBL_STAMPCHARGE", "Retail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Charge).HasColumnName("CHARGE");

                entity.Property(e => e.Chartofaccountid).HasColumnName("CHARTOFACCOUNTID");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("date");

                entity.HasOne(d => d.tblFinanceChartOfAccount)
                    .WithMany(p => p.TblStampcharge)
                    .HasForeignKey(d => d.Chartofaccountid)
                    .HasConstraintName("FK_TBL_Finance_tbl_FinanceChartOfAccount");

            });

            modelBuilder.Entity<TblCasaproductconversiontracker>(entity =>
            {
                entity.ToTable("TBL_CASAPRODUCTCONVERSIONTRACKER", "Customer");

                entity.HasKey(e => e.Casaprodconvid);

                entity.Property(e => e.Casaprodconvid)
                    .HasColumnName("CASAPRODCONVID");

                entity.Property(e => e.Approvalstatus)
                    .HasColumnName("APPROVALSTATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.Casaaccountid).HasColumnName("CASAACCOUNTID");

                entity.Property(e => e.Copyfileid).HasColumnName("COPYFILEID");

                entity.Property(e => e.Deleteflag).HasColumnName("DELETEFLAG");

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisapproved).HasColumnName("ISDISAPPROVED");

                entity.Property(e => e.Isnewlycreated).HasColumnName("ISNEWLYCREATED");

                entity.Property(e => e.Newproductid).HasColumnName("NEWPRODUCTID");

                entity.Property(e => e.Oldproductid).HasColumnName("OLDPRODUCTID");

                /* entity.HasOne(d => d.Casaaccount)
                     .WithMany(p => p.TblCasaproductconversiontracker)
                     .HasForeignKey(d => d.Casaaccountid)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_TBL_CASAPRODUCTCONVERSIONTRACKER_TBL_CASA");*/
            });

            modelBuilder.Entity<TblCustomercustomfieldlist>(entity =>
            {
                entity.ToTable("TBL_CUSTOMERCUSTOMFIELDLIST", "Customer");

                entity.Property(e => e.InputLabel)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.InputName)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<TblCustomercustomfieldoptions>(entity =>
            {
                entity.ToTable("TBL_CUSTOMERCUSTOMFIELDOPTIONS", "Customer");

                entity.Property(e => e.OptionName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblStaffInformation>(entity =>
            {
                entity.ToTable("tbl_StaffInformation", "GeneralSetup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Age).HasColumnType("DateTime");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationCode)
            .HasMaxLength(100)
            .IsUnicode(false);

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Miscode)
                    .HasColumnName("MISCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKinAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKinEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKinGender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKinName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NextOfKinPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PcCode)
                    .HasColumnName("pcCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
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

                entity.Property(e => e.Staffsignature)
                 .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageData)
                .HasColumnName("imageData")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageTitle)
                    .HasColumnName("imageTitle")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });


        }
    }
}
