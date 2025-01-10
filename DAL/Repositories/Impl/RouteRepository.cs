using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Impl
{
    public class RouteRepository : BaseRepository<Route>, IRouteRepository
    {
        public RouteRepository(SystemOfMonitoringAndManagingOfComunalVehieclesContext context) : base(context)
        {
        }
        public IEnumerable<Route> GetRoutesByStation(int stationId)
        {
            return Find(route => route.stations.Any(station => station.id == stationId)).ToList();
        }
        public IEnumerable<Route> GetRoutesByVehiecleID(int vehiecleId)
        {
            return Find(route => route.vehiecles.Any(vehiecle => vehiecle.id == vehiecleId)).ToList();
        }
    }
}
