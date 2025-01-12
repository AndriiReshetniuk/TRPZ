using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class StationDTO
    {
        public int id { get; set; }
        public string name { get; set; }

        public double longtitude { get; set; }

        public double latitude { get; set; }
    }
}
