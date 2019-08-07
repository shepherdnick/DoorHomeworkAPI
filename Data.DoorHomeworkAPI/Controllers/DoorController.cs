using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.DoorHomeworkAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Data.DoorHomeworkAPI.Controllers
{
    /// <summary>
    /// Controller for providing access to the doors API
    /// </summary>
    public class DoorController : Controller
    {
        private readonly IDoorRepository doorRepository;

        /// <summary>
        /// Constructor for the door repository
        /// </summary>
        /// <param name="doorRepo">The IDoorRepository dependency</param>
        public DoorController(IDoorRepository doorRepo)
        {
            doorRepository = doorRepo;
        }

        /// <summary>
        /// The basic index function to prove the shard is working
        /// </summary>
        /// <returns>A confirmation string</returns>
        [HttpGet("Index")]
        public string Index() => "This is from the door controller";

        /// <summary>
        /// Gets the doors for the system
        /// </summary>
        /// <returns>The doors for the system</returns>
        [HttpGet("GetDoors")]
        public IEnumerable<Object> GetDoors()
        {
            return doorRepository.GetDoors().Select(x => new { x.BuildingId, x.DoorId, x.Name });
        }

        /// <summary>
        /// Opens a door with the provided door id
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>Success or failure of the door open function</returns>
        [HttpPost("OpenDoor")]
        public bool OpenDoor(long doorId)
        {
            return doorRepository.OpenDoor(doorId);
        }

        /// <summary>
        /// Closes a door with the provided door id
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>Success or failure of the door close function</returns>
        [HttpPost("CloseDoor")]
        public bool CloseDoor(long doorId)
        {
            if (doorId == 1)
            {
                throw new Exception("Unable to find door with doorId " + doorId);
            }
            return doorRepository.CloseDoor(doorId);
        }

        /// <summary>
        /// Locks a door with the provided door id
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>Success or failure of the door lock function</returns>
        [HttpPost("LockDoor")]
        public bool LockDoor(long doorId)
        {
            return doorRepository.LockDoor(doorId);
        }

        /// <summary>
        /// Unlocks a door with the provided door id
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>Success or failure of the door unlocks function</returns>
        [HttpPost("UnlockDoor")]
        public bool UnlockDoor(long doorId)
        {
            return doorRepository.UnlockDoor(doorId);
        }

        /// <summary>
        /// Get the door status for the door id provided
        /// </summary>
        /// <param name="doorId">The door id</param>
        /// <returns>The updated door status</returns>
        [HttpGet("GetStatus")]
        public DoorStatus GetDoorStatus(long doorId)
        {
            return doorRepository.GetDoorStatus(doorId);
        }
    }
}