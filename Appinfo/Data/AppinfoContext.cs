using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Appinfo.Models
{
    public class AppinfoContext : DbContext
    {
        public AppinfoContext (DbContextOptions<AppinfoContext> options)
            : base(options)
        {
        }

        public DbSet<Appinfo.Models.New> New { get; set; }
    }
}
