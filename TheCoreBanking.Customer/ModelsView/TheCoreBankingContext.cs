using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TheCoreBanking.Customer.ModelsView
{
    public partial class TheCoreBankingContext : DbContext
    {
        public virtual DbSet<TblCustomercustomfieldlist> TblCustomercustomfieldlist { get; set; }
        public virtual DbSet<TblCustomercustomfieldoptions> TblCustomercustomfieldoptions { get; set; }

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
        }
    }
}
