using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Station
    {
        public int id { get; set; }
        public string name { get; set; }

        public double longtitude { get; set; }

        public double latitude { get; set; }

    }
}
