using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Data.DoorHomeworkAPI.Models
{
    /// <summary>
    /// Class for handling the door repository
    /// </summary>
    public class DoorRepository : IDoorRepository
    {
        private Dictionary<long, Door> doors;

        /// <summary>
        /// Constructor for the door repository
        /// </summary>
        public DoorRepository()
        {
            doors = new Dictionary<long, Door>();
            new List<Door>
            {
                new Door {BuildingId = 1, Name = "Front door", DoorId = 1, Status = DoorStatus.ClosedUnlocked },
                new Door {BuildingId = 1, Name = "Back door", DoorId = 2, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 2, Name = "Front door", DoorId = 3, Status = DoorStatus.ClosedLocked }
            }.ForEach(d => AddDoor(d));
        }

        /// <summary>
        /// Adds a door to the door repository
        /// </summary>
        /// <param name="door"></param>
        public void AddDoor(Door door)
        {
            doors[door.DoorId] = door;
        }

        /// <summary>
        /// Opens the door with the provided door id
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>Success or failure of the door open function</returns>
        public bool OpenDoor(long doorId)
        {
            Door door = doors[doorId];
            if (door.Status == DoorStatus.ClosedLocked || door.Status == DoorStatus.OpenLocked)
            {
                door.Status = DoorStatus.OpenLocked;
            }
            else
            {
                door.Status = DoorStatus.OpenUnlocked;
            }

            return true;
        }

        /// <summary>
        /// Closes the door with the provided door id
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>Success or failure of the door close function</returns>
        public bool CloseDoor(long doorId)
        {
            Door door = doors[doorId];
            if (door.Status == DoorStatus.ClosedLocked || door.Status == DoorStatus.OpenLocked)
            {
                door.Status = DoorStatus.ClosedLocked;
            }
            else
            {
                door.Status = DoorStatus.OpenLocked;
            }

            return true;
        }

        /// <summary>
        /// Locks the door with the provided door id
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>Success or failure of the door lock function</returns>
        public bool LockDoor(long doorId)
        {
            Door door = doors[doorId];
            if (door.Status == DoorStatus.ClosedLocked || door.Status == DoorStatus.ClosedUnlocked)
            {
                door.Status = DoorStatus.ClosedLocked;
            }
            else
            {
                door.Status = DoorStatus.OpenLocked;
            }

            return true;
        }

        /// <summary>
        /// Unlocks the door with the provided door id
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>Success or failure of the door lock function</returns>
        public bool UnlockDoor(long doorId)
        {
            Door door = doors[doorId];
            if (door.Status == DoorStatus.ClosedLocked || door.Status == DoorStatus.ClosedUnlocked)
            {
                door.Status = DoorStatus.ClosedUnlocked;
            }
            else
            {
                door.Status = DoorStatus.OpenUnlocked;
            }

            return true;
        }

        /// <summary>
        /// Gets a list of the doors for the system
        /// </summary>
        /// <returns>A basic list of doors for the system</returns>
        public IEnumerable<Door> GetDoors()
        {
            return doors.Values;
        }

        /// <summary>
        /// Gets the door's status for the provided door id
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>The updated door status for the door id provided</returns>
        public DoorStatus GetDoorStatus(long doorId)
        {
            Door door = doors[doorId];
            return door.Status;
        }        
    }
}
