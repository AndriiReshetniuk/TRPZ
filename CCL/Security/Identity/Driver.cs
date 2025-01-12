using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL.Security.Identity
{
    public class Driver : User
    {
        public Driver(int userId, string name, List <int> RoutesId)
            : base(userId, name, RoutesId, nameof(Driver))
        {

        }
    }
}
