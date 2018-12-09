using CrashService.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrashService.DAL.Models.DomainModels
{
    class Detector : BaseEntity<int>
    {
        public string Location { get; set; }
    }
}
