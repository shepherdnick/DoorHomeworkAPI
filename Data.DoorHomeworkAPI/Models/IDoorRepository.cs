﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.DoorHomeworkAPI.Models
{
    public interface IDoorRepository
    {
        IEnumerable<Door> GetDoors();
        DoorStatus GetDoorStatus(long doorId);
        bool OpenDoor(long doorId);
        bool CloseDoor(long doorId);
        bool LockDoor(long doorId);
        bool UnlockDoor(long doorId);
    }
}
