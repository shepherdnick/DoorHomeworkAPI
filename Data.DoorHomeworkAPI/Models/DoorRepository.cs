using System.Collections.Generic;

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
                new Door {BuildingId = 1, Name = "Side door", DoorId = 22, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 2, Name = "Front door", DoorId = 3, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 2, Name = "Back door", DoorId = 4, Status = DoorStatus.ClosedUnlocked },
                new Door {BuildingId = 2, Name = "Balcony door", DoorId = 24, Status = DoorStatus.ClosedUnlocked },
                new Door {BuildingId = 3, Name = "Front door", DoorId = 5, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 3, Name = "Back door", DoorId = 6, Status = DoorStatus.OpenLocked },
                new Door {BuildingId = 4, Name = "Front door", DoorId = 7, Status = DoorStatus.OpenLocked },
                new Door {BuildingId = 4, Name = "Back door", DoorId = 8, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 4, Name = "1st floor fire exit", DoorId = 28, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 4, Name = "2nd floor fire exit", DoorId = 29, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 5, Name = "Front door", DoorId = 9, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 16, Name = "Front door", DoorId = 11, Status = DoorStatus.ClosedUnlocked },
                new Door {BuildingId = 16, Name = "Back door", DoorId = 12, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 17, Name = "Front door", DoorId = 13, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 17, Name = "Back door", DoorId = 14, Status = DoorStatus.ClosedUnlocked },
                new Door {BuildingId = 17, Name = "West fire exit", DoorId = 140, Status = DoorStatus.ClosedUnlocked },
                new Door {BuildingId = 18, Name = "Front entrance", DoorId = 15, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 18, Name = "Back door", DoorId = 16, Status = DoorStatus.OpenLocked },
                new Door {BuildingId = 19, Name = "Front door", DoorId = 17, Status = DoorStatus.OpenLocked },
                new Door {BuildingId = 19, Name = "Side door", DoorId = 18, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 19, Name = "East fire exit", DoorId = 180, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 19, Name = "West fire exit", DoorId = 190, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 20, Name = "Front door", DoorId = 19, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 20, Name = "Back door", DoorId = 20, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 31, Name = "Front door", DoorId = 31, Status = DoorStatus.ClosedUnlocked },
                new Door {BuildingId = 31, Name = "Back door", DoorId = 36, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 32, Name = "Front door", DoorId = 32, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 32, Name = "Back door", DoorId = 37, Status = DoorStatus.ClosedUnlocked },
                new Door {BuildingId = 32, Name = "West side door", DoorId = 370, Status = DoorStatus.ClosedUnlocked },
                new Door {BuildingId = 32, Name = "West back entrance", DoorId = 371, Status = DoorStatus.ClosedUnlocked },
                new Door {BuildingId = 33, Name = "Front door", DoorId = 33, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 33, Name = "Back door", DoorId = 38, Status = DoorStatus.OpenLocked },
                new Door {BuildingId = 34, Name = "Front entrance", DoorId = 34, Status = DoorStatus.OpenLocked },
                new Door {BuildingId = 34, Name = "Back entrance", DoorId = 39, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 34, Name = "Side balcony", DoorId = 390, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 35, Name = "Front door", DoorId = 35, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 35, Name = "Back door", DoorId = 40, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 606, Name = "Front door", DoorId = 99, Status = DoorStatus.ClosedUnlocked },
                new Door {BuildingId = 606, Name = "Back door", DoorId = 98, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 404, Name = "Front door", DoorId = 97, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 404, Name = "Back door", DoorId = 96, Status = DoorStatus.ClosedUnlocked },
                new Door {BuildingId = 909, Name = "Garage door", DoorId = 95, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 909, Name = "Garage interior door", DoorId = 94, Status = DoorStatus.OpenLocked },
                new Door {BuildingId = 910, Name = "Front door", DoorId = 93, Status = DoorStatus.OpenLocked },
                new Door {BuildingId = 910, Name = "Back door", DoorId = 92, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 911, Name = "Garden entrance", DoorId = 91, Status = DoorStatus.ClosedLocked },
                new Door {BuildingId = 911, Name = "Front entrance", DoorId = 999, Status = DoorStatus.ClosedLocked },
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
