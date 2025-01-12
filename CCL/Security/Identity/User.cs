using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL.Security.Identity
{
    public abstract class User
    {
        public int UserId { get; }
        public string Name { get; }
        public List <int> RoutesId { get; }
        protected string UserType { get; }
        public User(int userId, string name, List <int> routesId, string userType)
        {
            UserId = userId;
            Name = name;
            RoutesId = routesId;
            UserType = userType;
        }
    }
}
