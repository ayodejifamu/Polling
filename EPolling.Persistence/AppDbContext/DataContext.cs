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
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options)
        {
        }
        
        public DbSet<States> States { get; set; }
        public DbSet<LGAs> LGAs { get; set; }
        public DbSet<Wards> Wards { get; set; }
    }
}

