using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TheCoreBankingFileContext : DbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
#if DEBUG
                // optionsBuilder.UseSqlServer(@"Server=DESKTOP-5VJ567N\FINTRAKSQL;Database=TheCoreBanking.Files;User Id=sa;Password=sqluser10$;");
                //optionsBuilder.UseSqlServer(@"Server=fintraksqlmmbs.database.windows.net;Database=TheCoreBanking.Files;User Id=fintrak;Password=Password20$;");
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-BKMHOIU;Database=TestPractice;");
#else
                optionsBuilder.UseSqlServer(@"Server=fintraksqlmmbs.database.windows.net;Database=TheCoreBanking.Files;User Id=fintrak;Password=Password20$;");
#endif
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
