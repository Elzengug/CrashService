using CrashService.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrashService.DAL.Models.DomainModels
{
    public class Client : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
