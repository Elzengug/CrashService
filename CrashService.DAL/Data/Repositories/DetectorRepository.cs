using CrashService.DAL.Contracts.Context;
using CrashService.DAL.Contracts.Repositories;
using CrashService.DAL.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrashService.DAL.Data.Repositories
{
    public class DetectorRepository: GenericRepository<Detector>, IDetectorRepository
    {
        public DetectorRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
