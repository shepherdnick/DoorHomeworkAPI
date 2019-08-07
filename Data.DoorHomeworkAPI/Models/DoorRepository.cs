using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.DoorHomeworkAPI.Models
{
    public class DoorRepository : IDoorRepository
    {
        private Dictionary<long, Door> doors;

        public DoorRepository()
        {
            doors = new Dictionary<long, Door>();
            new List<Door>
            {
                new Door {BuildingId = 1, Name = "Front door", DoorId = 1, Status = DoorStatus.ClosedUnlocked },
                new Door {BuildingId = 1, Name = "Back door", DoorId = 2, Status = DoorStatus.OpenUnlocked },
                new Door {BuildingId = 2, Name = "Front door", DoorId = 1, Status = DoorStatus.ClosedLocked }
            }.ForEach(d => AddDoor(d));
        }

        public void AddDoor(Door door)
        {
            doors[door.DoorId] = door;
        }

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

        public IEnumerable<Door> GetDoors()
        {
            return doors.Values;
        }

        public DoorStatus GetDoorStatus(long doorId)
        {
            Door door = doors[doorId];
            return door.Status;
        }        
    }
}
