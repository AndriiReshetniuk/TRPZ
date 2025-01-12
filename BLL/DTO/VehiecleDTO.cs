using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class VehiecleDTO
    {
        public DriverDTO[] driver { get; set; }

        public int id { get; set; }

        public string technicalState { get; set; }

        public string model { get; set; }
    }
}
