using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL.Security.Identity
{
    public class Logist : User
    {
        public Logist(int userId, string name, List <int> RoutesId)
            : base(userId, name, RoutesId, nameof(Logist))
        {

        }
    }
}
