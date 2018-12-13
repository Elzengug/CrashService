using CrashService.DAL.Contracts.Context;
using CrashService.DAL.Contracts.Repositories;
using CrashService.DAL.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrashService.DAL.Data.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
