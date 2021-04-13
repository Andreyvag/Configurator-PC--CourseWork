using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Configurator_PC.Models
{
    public class AccessoriesContext : DbContext
    {
        public DbSet<Processor> Processors { get; set; }
        public DbSet<VideoCard> VideoCards { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<Cooling> Coolings { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<SSD> SSDs { get; set; }
        public DbSet<HardDrive> HardDrives { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<SoundCard> SoundCards { get; set; }
        public DbSet<NetworkAdapter> NetworkAdapters { get; set; }
        public DbSet<Configurator> Configurators { get; set; }

        public AccessoriesContext(DbContextOptions<AccessoriesContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public class ApplicationContext : IdentityDbContext<User>
        {
            public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        }
    }
}