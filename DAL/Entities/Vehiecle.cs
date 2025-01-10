using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Vehiecle
    {
        public Driver[] driver { get; set; }

        public int id { get; set; }

        public string technicalState { get; set; }

        public string model { get; set; }

    }
}
