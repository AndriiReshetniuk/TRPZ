using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Microsoft.EntityFrameworkCore;
using System.IO;
using DAL.Entities;


namespace DAL.Tests
{
    public class BaseRepositoryUnitTests
    {
        [Fact]
        public void Create_InputStreetInstance_CalledAddMethodOfDBSetWithStreetInstance()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<SystemOfMonitoringAndManagingOfComunalVehieclesContext>()
            .Options;
            var mockContext = new Mock<SystemOfMonitoringAndManagingOfComunalVehieclesContext>(opt);
            var mockDbSet = new Mock<DbSet<Station>>();
            mockContext
            .Setup(context =>
            context.Set<Station>(
            ))
            .Returns(mockDbSet.Object);
            var repository = new TestStationRepository(mockContext.Object);
            Station expectedStation = new Mock<Station>().Object;
            //Act
            repository.Create(expectedStation);
            // Assert
            mockDbSet.Verify(
            dbSet => dbSet.Add(
            expectedStation
            ), Times.Once());
        }

        [Fact]
        public void Get_InputId_CalledFindMethodOfDBSetWithCorrectId()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<SystemOfMonitoringAndManagingOfComunalVehieclesContext>()
            .Options;
            var mockContext = new Mock<SystemOfMonitoringAndManagingOfComunalVehieclesContext>(opt);
            var mockDbSet = new Mock<DbSet<Station>>();
            mockContext
            .Setup(context =>
            context.Set<Station>(
            ))
            .Returns(mockDbSet.Object);
            Station expectedStation = new Station() { id = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedStation.id))
            .Returns(expectedStation);
            var repository = new TestStationRepository(mockContext.Object);
            //Act
            var actualStation = repository.Get(expectedStation.id);
            // Assert
            mockDbSet.Verify(
            dbSet => dbSet.Find(
            expectedStation.id
            ), Times.Once());
            Assert.Equal(expectedStation, actualStation);
        }

        [Fact]
        public void Delete_InputId_CalledFindAndRemoveMethodsOfDBSetWithCorrectArg()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<SystemOfMonitoringAndManagingOfComunalVehieclesContext>()
            .Options;
            var mockContext = new Mock<SystemOfMonitoringAndManagingOfComunalVehieclesContext>(opt);
            var mockDbSet = new Mock<DbSet<Station>>();
            mockContext
            .Setup(context =>
            context.Set<Station>(
            ))
            .Returns(mockDbSet.Object);
            var repository = new TestStationRepository(mockContext.Object);
            Station expectedStreet = new Station() { id = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedStreet.id))
            .Returns(expectedStreet);
            //Act
            repository.Delete(expectedStreet.id);
            // Assert
            mockDbSet.Verify(
            dbSet => dbSet.Find(
            expectedStreet.id
            ), Times.Once());
            mockDbSet.Verify(
            dbSet => dbSet.Remove(
            expectedStreet
            ), Times.Once());

        }
    }
} 
