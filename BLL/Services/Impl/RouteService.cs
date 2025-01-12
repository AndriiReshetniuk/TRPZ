using AutoMapper;
using BLL.DTO;
using BLL.Services.Interfaces;
using CCL.Security;
using CCL.Security.Identity;
using DAL.Entities;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Impl
{
    public class RouteService : IRouteService
    {
        private readonly IUnitOfWork _database;
        private int pageSize = 10;
        public RouteService(
        IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            _database = unitOfWork;
        }
        /// <exception cref="MethodAccessException"></exception>
        public IEnumerable<RouteDTO> GetRoutes(int pageNumber)
        {
            var user = SecurityContext.GetUser();
            var userType = user.GetType();
            if (userType != typeof(CCL.Security.Identity.Driver)
            && userType != typeof(Logist)
            && userType != typeof(Mechanic))
            {
                throw new MethodAccessException();
            }
            var RoutesId = user.RoutesId;
            var routesEntities =
            _database
            .Routes
            .Find(z => RoutesId.Contains(z.id), pageNumber, pageSize);
            var mapper =
            new MapperConfiguration(cfg => cfg.CreateMap<Route, RouteDTO>()).CreateMapper();
            var streetsDto =
            mapper
            .Map<IEnumerable<Route>, List<RouteDTO>>(
            routesEntities);
            return streetsDto;
        }
    }
}
