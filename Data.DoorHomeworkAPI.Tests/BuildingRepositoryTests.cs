using Data.DoorHomeworkAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.DoorHomeworkAPI.Tests
{
    [TestClass]
    public class BuildingRepositoryTests
    {
        [TestMethod]
        public void AddBuilding_TwoBuildings()
        {
            // Arrange
            Building b1 = new Building { BuildingId = 1000, Name = "BLD001" };
            Building b2 = new Building { BuildingId = 2000, Name = "BLD002" };

            BuildingRepository buildingRepo = new BuildingRepository();

            // Act
            buildingRepo.AddBuilding(b1);
            buildingRepo.AddBuilding(b2);

            Building[] buildings = buildingRepo.GetBuildings().ToArray();

            // Assert
            Assert.AreEqual(22, buildings.Length);
            Assert.AreEqual(b1, buildings[20]);
            Assert.AreEqual(b2, buildings[21]);
        }

        [TestMethod]
        public void RemoveBuilding_TwoBuildings()
        {
            // Arrange
            BuildingRepository buildingRepo = new BuildingRepository();

            // Act
            buildingRepo.RemoveBuilding(1);
            buildingRepo.RemoveBuilding(2);

            Building[] buildings = buildingRepo.GetBuildings().ToArray();

            // Assert
            Assert.AreEqual(18, buildings.Length);
        }

        [TestMethod]
        public void RemoveBuilding_AllBuildings()
        {
            // Arrange
            BuildingRepository buildingRepo = new BuildingRepository();

            // Act
            buildingRepo.GetBuildings().ToList().ForEach(b => buildingRepo.RemoveBuilding(b.BuildingId));

            Building[] buildings = buildingRepo.GetBuildings().ToArray();

            // Assert
            Assert.AreEqual(0, buildings.Length);
        }
    }
}
