using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {     
        IRouteRepository Routes { get;  }
        IDriverRepository Drivers { get; }
        IStationRepository Stations { get; }
        IUserRepository Users { get; }
        IVehiecleRepository Vehiecles { get; }

        void Save();   
    }
}
