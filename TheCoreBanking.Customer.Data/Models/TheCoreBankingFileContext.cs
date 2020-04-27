using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TheCoreBankingFileContext : DbContext
    {
        public virtual DbSet<TblKycdocuments> TblKycdocuments { get; set; }
        public virtual DbSet<TblMandateimages> TblMandateimages { get; set; }
        public virtual DbSet<TblRefereedocuments> TblRefereedocuments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
#if DEBUG
                 optionsBuilder.UseSqlServer(@"Server=DESKTOP-5VJ567N\FINTRAKSQL;Database=TheCoreBanking.Files;User Id=sa;Password=sqluser10$;");
               // optionsBuilder.UseSqlServer(@"Server=fintraksqlmmbs.database.windows.net;Database=TheCoreBanking.Files;User Id=fintrak;Password=Password20$;");
#else
                optionsBuilder.UseSqlServer(@"Server=fintraksqlmmbs.database.windows.net;Database=TheCoreBankingAzure;User Id=fintrak;Password=Password20$;");
#endif
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblKycdocuments>(entity =>
            {
                entity.ToTable("TBL_KYCDOCUMENTS", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Filedata)
                    .IsRequired()
                    .HasColumnName("FILEDATA")
                    .HasColumnType("image");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Mime)
                    .HasColumnName("MIME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMandateimages>(entity =>
            {
                entity.HasKey(e => e.Fileid);

                entity.ToTable("TBL_MANDATEIMAGES", "Customer");

                entity.Property(e => e.Fileid).HasColumnName("FILEID");

                entity.Property(e => e.Byte)
                    .IsRequired()
                    .HasColumnName("BYTE")
                    .HasColumnType("image");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Mandateid).HasColumnName("MANDATEID");

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Isdisapproved).HasColumnName("ISDISAPPROVED");

                entity.Property(e => e.Approvalstatus).HasColumnName("APPROVALSTATUS");

                entity.Property(e => e.Mime)
                    .HasColumnName("MIME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRefereedocuments>(entity =>
            {
                entity.ToTable("TBL_REFEREEDOCUMENTS", "Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Filedata)
                    .IsRequired()
                    .HasColumnName("FILEDATA")
                    .HasColumnType("image");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Mime)
                    .IsRequired()
                    .HasColumnName("MIME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Refereeid).HasColumnName("REFEREEID");
            });
        }
    }
}
