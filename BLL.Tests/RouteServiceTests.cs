using BLL.Services.Impl;
using CCL.Security.Identity;
using CCL.Security;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using BLL.Services.Interfaces;
using System.IO;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Tests
{
    public class RouteServiceTests
    {
        [Fact]
        public void Ctor_InputNull_ThrowArgumentNullException()
        {
            // Arrange
            IUnitOfWork nullUnitOfWork = null;
            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(
            () => new RouteService(nullUnitOfWork)
            );
        }


        [Fact]
        public void GetRoutes_UserIsAdmin_ThrowMethodAccessException()
        {
            // Arrange
            List<int> RoutesIds = new List<int> { 1 };
            CCL.Security.Identity.User user = new Admin(1, "test", RoutesIds);
            SecurityContext.SetUser(user);
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            IRouteService routeService = new RouteService(mockUnitOfWork.Object);
            // Act
            // Assert
            Assert.Throws<MethodAccessException>(() => routeService.GetRoutes(0));
        }

        [Fact]
        public void GetRoutes_RouteFromDAL_CorrectMappingToRouteDTO()
        {
            // Arrange
            List<int> RoutesIds = new List<int> { 1 };
            CCL.Security.Identity.User user = new Logist(1, "test", RoutesIds);
            SecurityContext.SetUser(user);
            var routeService = GetRouteService();
            // Act
            var actualRouteDto = routeService.GetRoutes(0).First();
            // Assert
            Assert.True(
            actualRouteDto.id == 1
            && actualRouteDto.name == "testN");
        }

        IRouteService GetRouteService()
        {
            var mockContext = new Mock<IUnitOfWork>();
            var expectedRoute = new Route()
            {
                id = 1,
                name = "testN",
            };
            var mockDbSet = new Mock<IRouteRepository>();
            mockDbSet
            .Setup(z =>
            z.Find(
            It.IsAny<Func<Route, bool>>(),
            It.IsAny<int>(),
            It.IsAny<int>()))
            .Returns(new List<Route>() { expectedRoute });
            mockContext
            .Setup(context =>
            context.Routes)
            .Returns(mockDbSet.Object);
            IRouteService routeService = new RouteService(mockContext.Object);
            return routeService;

        }
    }
}
