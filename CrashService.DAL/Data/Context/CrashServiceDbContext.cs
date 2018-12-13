using CrashService.DAL.Contracts.Context;
using CrashService.DAL.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CrashService.DAL.Data.Context
{
    class CrashServiceDbContext : DbContext, IDbContext
    {
        // public const string ConnectionString =
        //@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookShopDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public CrashServiceDbContext() : base("DefaultConnection")
        {

        }
        public static CrashServiceDbContext Create()
        {
            return new CrashServiceDbContext();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Client>().HasKey(k => new { k.ClientId, k.GroupId });
        //    modelBuilder.Entity<Employee>().HasKey(k => new { k.ClientId, k.MessageId });
        //    modelBuilder.Entity<Detector>().HasKey(k => new { k.ClientId, k.JobId });
        //}
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Detector> Detectors { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
