using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TheCoreBanking.Customer.ModelsView
{
    public partial class TheCoreBankingContext : DbContext
    {
        public virtual DbSet<TblCasa> TblCasa { get; set; }
        public virtual DbSet<TblCasaproductconversiontracker> TblCasaproductconversiontracker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=.\FINTRAKSQL;Database=TheCoreBanking; user id=sa; password=sqluser10$;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

                entity.Property(e => e.Approvalstatusid)
                    .HasColumnName("APPROVALSTATUSID")
                    .HasDefaultValueSql("((0))");

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

                entity.Property(e => e.Customercode)
                    .HasColumnName("CUSTOMERCODE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

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

                entity.Property(e => e.Operationid)
                    .HasColumnName("OPERATIONID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Overdraftamount)
                    .HasColumnName("OVERDRAFTAMOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Overdraftexpirydate)
                    .HasColumnName("OVERDRAFTEXPIRYDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Overdraftinterestrate)
                    .HasColumnName("OVERDRAFTINTERESTRATE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Postnostatusid)
                    .HasColumnName("POSTNOSTATUSID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Productcode)
                    .HasColumnName("PRODUCTCODE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

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
            });

            modelBuilder.Entity<TblCasaproductconversiontracker>(entity =>
            {
                entity.ToTable("TBL_CASAPRODUCTCONVERSIONTRACKER", "Customer");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

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

                entity.HasOne(d => d.Casaaccount)
                    .WithMany(p => p.TblCasaproductconversiontracker)
                    .HasForeignKey(d => d.Casaaccountid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_CASAPRODUCTCONVERSIONTRACKER_TBL_CASA");
            });
        }
    }
}
