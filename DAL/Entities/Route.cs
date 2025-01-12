using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Route
    {
        public int id { get; set; }
        public string name { get; set; }

        public Station [] stations { get; set; }

        public Vehiecle [] vehiecles { get; set; }

        public DateTime [] timeOfStations { get; set; }
    }
}
