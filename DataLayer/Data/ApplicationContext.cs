using DemoWebApi.Common.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApiApps.Data.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions options): base(options) { }
        public virtual DbSet<UserDto> users { get; set; }
    }
}
