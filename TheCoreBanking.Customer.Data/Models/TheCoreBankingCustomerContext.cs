using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TheCoreBanking.Customer.Data.ProcedureAndFunctionDTO;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TheCoreBankingCustomerContext : DbContext
    {
       
        public virtual DbSet<TblCustomer> TblCustomer { get; set; }
       





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.

#if DEBUG
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-BKMHOIU;Database=TestPractice;");

              // optionsBuilder.UseSqlServer(@"Server=fintraksqlmmbs.database.windows.net;Database=TheCoreBankingAzure;User Id=fintrak;Password=Password20$;");

#else
               
                 optionsBuilder.UseSqlServer(@"Server=fintraksqlmmbs.database.windows.net;Database=TheCoreBankingAzure;User Id=fintrak;Password=Password20$;");
               
#endif
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
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

                
            });

           


        }
    }
}
