using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class SystemOfMonitoringAndManagingOfComunalVehieclesContext : DbContext
    {
        public DbSet<Route> Routes { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Vehiecle> Vehicles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public SystemOfMonitoringAndManagingOfComunalVehieclesContext(DbContextOptions options)
        : base(options)
        {
        }

    }
}
