using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class RouteDTO
    {
        public int id { get; set; }
        public string name { get; set; }

        public StationDTO[] stations { get; set; }

        public VehiecleDTO[] vehiecles { get; set; }

        public DateTime[] timeOfStations { get; set; }
    }
}
