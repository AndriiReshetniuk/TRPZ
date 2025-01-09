using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Impl
{
    public class StationRepository : BaseRepository<Station>, IStationRepository
    {
        public StationRepository(SystemOfMonitoringAndManagingOfComunalVehieclesContext context) : base(context)
        {

        }
    }
}
