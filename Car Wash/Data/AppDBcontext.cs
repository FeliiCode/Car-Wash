using System.Security.Cryptography.X509Certificates;
using Car_Wash.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace Car_Wash.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<PaketCuci> PaketCucis => Set<PaketCuci>();
        public DbSet<PembayaranJasa> PembayaranJasas => Set<PembayaranJasa>();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;" +
                "Database= db_vb2_car_wash;" +
                "Username=postgres;Password=");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PembayaranJasa>()
        //        .HasOne(l => l.SampleMaster)
        //        .WithMany(m => m.SampleTrans)
        //        .HasForeignKey(l => l.SampleMasterId);

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
