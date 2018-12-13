using CrashService.DAL.Contracts.Context;
using CrashService.DAL.Contracts.Repositories;
using CrashService.DAL.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrashService.DAL.Data.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
