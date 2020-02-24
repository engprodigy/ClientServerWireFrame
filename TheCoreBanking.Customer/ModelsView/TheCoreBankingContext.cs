using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TheCoreBanking.Customer.ModelsView
{
    public partial class TheCoreBankingContext : DbContext
    {
        public virtual DbSet<TblDesignation> TblDesignation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=BANKINGPLATFORM\FINTRAKSQL;Database=TheCoreBanking; user id=sa; password=sqluser10$;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblDesignation>(entity =>
            {
                entity.ToTable("tbl_Designation", "GeneralSetup");

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.HasSequence("seqGetNextBatchRef")
                .StartsAt(25000)
                .HasMin(25000);

            modelBuilder.HasSequence("TransactionSequence").HasMin(0);
        }
    }
}
