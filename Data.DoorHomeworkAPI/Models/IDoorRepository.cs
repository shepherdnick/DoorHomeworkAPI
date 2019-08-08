using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.DoorHomeworkAPI.Models
{
    /// <summary>
    /// Inreface for a door repository
    /// </summary>
    public interface IDoorRepository
    {
        /// <summary>
        /// Opens the door with the provided door ID
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>Success or failure</returns>
        bool OpenDoor(long doorId);

        /// <summary>
        /// Closes the door with the provided door ID
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>Success or failure</returns>
        bool CloseDoor(long doorId);

        /// <summary>
        /// Locks the door with the provided door ID
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>Success or failure</returns>
        bool LockDoor(long doorId);

        /// <summary>
        /// Unlocks the door with the provided door ID
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>Success or failure</returns>
        bool UnlockDoor(long doorId);

        /// <summary>
        /// Gets a list of doors from the repository
        /// </summary>
        /// <returns>A list of doors</returns>
        IEnumerable<Door> GetDoors();

        /// <summary>
        /// Gets the door status for the door id provided
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>The door status</returns>
        DoorStatus GetDoorStatus(long doorId);
    }
}
