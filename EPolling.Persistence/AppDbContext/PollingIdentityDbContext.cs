using EPolling.Domain.Identity;
using EPolling.Domain.Model;
using EPolling.Persistence.Configurations.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Persistence.AppDbContext
{
    public class PollingIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public PollingIdentityDbContext(DbContextOptions<PollingIdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
        }

        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<LGAs> LGAs { get; set; }
        public DbSet<Wards> Wards { get; set; }
        public DbSet<PollingUnits> PollingUnits{get; set;}


    }
}
