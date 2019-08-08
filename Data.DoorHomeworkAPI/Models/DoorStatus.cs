using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.DoorHomeworkAPI.Models
{
    /// <summary>
    /// Representation of a door status
    /// </summary>
    public enum DoorStatus
    {
        OpenLocked = 1,
        OpenUnlocked = 2,
        ClosedLocked = 3,
        ClosedUnlocked = 4
    }
}
