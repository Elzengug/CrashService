using CrashService.DAL.Contracts.Context;
using CrashService.DAL.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace CrashService.DAL.Data.Context
{
    public  class CrashServiceDbContext : DbContext, IDbContext
    {

        public CrashServiceDbContext(DbContextOptions<CrashServiceDbContext> options)
             : base(options)
        {
            Database.EnsureCreated();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Detector> Detectors { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
