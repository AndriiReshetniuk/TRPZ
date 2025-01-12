using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DriverDTO
    {
        public VehiecleDTO[] vehiecles { get; set; }
        public int id { get; set; }

        public string name { get; set; }

        public string email { get; set; }
    }
}
