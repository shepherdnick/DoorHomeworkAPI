using Data.DoorHomeworkAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.DoorHomeworkAPI.Tests
{
    [TestClass]
    public class DoorRepositoryTests
    {
        [TestMethod]
        public void GetDoors()
        {
            // Arrange 
            DoorRepository doorRepository = new DoorRepository();

            // Act
            Door[] doors = doorRepository.GetDoors().ToArray();

            // Assert
            Assert.AreEqual(46, doors.Length);
        }

        [TestMethod]
        public void AddDoor_TwoDoors()
        {
            // Arrange
            Door door1 = new Door { BuildingId = 1, DoorId = 1000, Name = "Door1000", Status = DoorStatus.ClosedLocked };
            Door door2 = new Door { BuildingId = 1, DoorId = 2000, Name = "Door2000", Status = DoorStatus.OpenLocked };

            DoorRepository doorRepository = new DoorRepository();

            // Act
            doorRepository.AddDoor(door1);
            doorRepository.AddDoor(door2);

            // Assert
            Door[] doors = doorRepository.GetDoors().ToArray();

            Assert.AreEqual(48, doors.Length);
            Assert.AreEqual(door1, doors[46]);
            Assert.AreEqual(door2, doors[47]);
        }

        [TestMethod]
        public void RemoveDoor_TwoDoors()
        {
            // Arrange
            Door door1 = new Door { BuildingId = 1, DoorId = 1000, Name = "Door1000", Status = DoorStatus.ClosedLocked };
            Door door2 = new Door { BuildingId = 1, DoorId = 2000, Name = "Door2000", Status = DoorStatus.OpenLocked };

            DoorRepository doorRepository = new DoorRepository();

            // Act
            doorRepository.RemoveDoor(1);
            doorRepository.RemoveDoor(2);

            // Assert
            Door[] doors = doorRepository.GetDoors().ToArray();

            Assert.AreEqual(44, doors.Length);
        }

        [TestMethod]
        public void RemoveDoor_AllBuildings()
        {
            // Arrange
            DoorRepository doorRepository = new DoorRepository();

            // Act
            doorRepository.GetDoors().ToList().ForEach(b => doorRepository.RemoveDoor(b.DoorId));

            Door[] doors = doorRepository.GetDoors().ToArray();

            // Assert
            Assert.AreEqual(0, doors.Length);
        }

        [TestMethod]
        public void OpenDoor_WithClosedLocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.ClosedLocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.OpenDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.OpenLocked);
        }

        [TestMethod]
        public void OpenDoor_WithClosedUnlocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.ClosedUnlocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.OpenDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.OpenUnlocked);
        }

        [TestMethod]
        public void OpenDoor_WithOpenUnlocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.OpenUnlocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.OpenDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.OpenUnlocked);
        }

        [TestMethod]
        public void OpenDoor_WithOpenLocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.OpenLocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.OpenDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.OpenLocked);
        }

        [TestMethod]
        public void CloseDoor_WithClosedLocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.ClosedLocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.CloseDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.ClosedLocked);
        }

        [TestMethod]
        public void CloseDoor_WithClosedUnlocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.ClosedUnlocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.CloseDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.ClosedUnlocked);
        }

        [TestMethod]
        public void CloseDoor_WithOpenUnlocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.OpenUnlocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.CloseDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.ClosedUnlocked);
        }

        [TestMethod]
        public void CloseDoor_WithOpenLocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.OpenLocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.CloseDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.ClosedLocked);
        }

        [TestMethod]
        public void LockDoor_WithClosedLocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.ClosedLocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.LockDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.ClosedLocked);
        }

        [TestMethod]
        public void LockDoor_WithClosedUnlocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.ClosedUnlocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.LockDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.ClosedLocked);
        }

        [TestMethod]
        public void LockDoor_WithOpenUnlocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.OpenUnlocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.LockDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.OpenLocked);
        }

        [TestMethod]
        public void LockDoor_WithOpenLocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.OpenLocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.LockDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.OpenLocked);
        }

        [TestMethod]
        public void UnlockDoor_WithClosedLocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.ClosedLocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.UnlockDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.ClosedUnlocked);
        }

        [TestMethod]
        public void UnlockDoor_WithClosedUnlocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.ClosedUnlocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.UnlockDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.ClosedUnlocked);
        }

        [TestMethod]
        public void UnlockDoor_WithOpenUnlocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.OpenUnlocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.UnlockDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.OpenUnlocked);
        }

        [TestMethod]
        public void UnlockDoor_WithOpenLocked()
        {
            // Arrange
            Door door = new Door { BuildingId = 1000, DoorId = 1000, Name = "Door 1000", Status = DoorStatus.OpenLocked };
            DoorRepository doorRepository = new DoorRepository();
            doorRepository.AddDoor(door);

            // Act
            doorRepository.UnlockDoor(door.DoorId);

            // Assert
            Assert.AreEqual(door.Status, DoorStatus.OpenUnlocked);
        }
    }
}
