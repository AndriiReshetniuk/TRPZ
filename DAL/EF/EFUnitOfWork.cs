using DAL.Entities;
using DAL.Repositories.Impl;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private SystemOfMonitoringAndManagingOfComunalVehieclesContext db;
        private RouteRepository routeRepository;
        private DriverRepository driverRepository;
        private StationRepository stationRepository;
        private UserRepository userRepository;
        private VehiecleRepository vehiecleRepository;
        public EFUnitOfWork(DbContextOptions options)
        {
            db = new SystemOfMonitoringAndManagingOfComunalVehieclesContext(options);
        }
        public IRouteRepository Routes
        {
            get
            {
                if (routeRepository == null)
                    routeRepository = new RouteRepository(db);
                return routeRepository;
            }
        }
        public IDriverRepository Drivers
        {
            get
            {
                if (driverRepository == null)
                    driverRepository = new DriverRepository(db);
                return driverRepository;
            }
        }
        public IStationRepository Stations
        {
            get
            {
                if (stationRepository == null)
                    stationRepository = new StationRepository(db);
                return stationRepository;
            }
        }
        public IVehiecleRepository Vehiecles
        {
            get
            {
                if (vehiecleRepository == null)
                    vehiecleRepository = new VehiecleRepository(db);
                return vehiecleRepository;
            }
        }
        public IUserRepository Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
