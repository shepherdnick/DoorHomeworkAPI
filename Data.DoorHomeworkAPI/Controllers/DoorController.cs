using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.DoorHomeworkAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Data.DoorHomeworkAPI.Controllers
{
    /// <summary>
    /// Controller for providing access to the doors API.
    /// </summary>
    [Produces("application/json")]
    [Route("Door")]
    public class DoorController : Controller
    {
        private readonly IDoorRepository doorRepository;
        private readonly IBuildingRepository buildingRepository;

        /// <summary>
        /// Constructor for the door repository.
        /// </summary>
        /// <param name="doorRepo">The IDoorRepository dependency.</param>
        /// <param name="buildingRepo">The IBuildingRepository dependency.</param>
        public DoorController(IDoorRepository doorRepo, IBuildingRepository buildingRepo)
        {
            doorRepository = doorRepo;
            buildingRepository = buildingRepo;
        }
        
        /// <summary>
        /// Gets the buildings for the system.
        /// </summary>
        /// <returns>A list of buildings for the system.</returns>
        [HttpGet("GetBuildings")]
        public IEnumerable<Building> GetBuildings()
        {
            return buildingRepository.GetBuildings();
        }

        /// <summary>
        /// Gets the doors for the system.
        /// </summary>
        /// <returns>The doors for the system.</returns>
        [HttpGet("GetDoors")]
        public IEnumerable<Object> GetDoors()
        {
            return doorRepository.GetDoors().Select(x => new { x.BuildingId, x.DoorId, x.Name });
        }

        /// <summary>
        /// Opens a door with the provided door id.
        /// </summary>
        /// <param name="doorId">The door id to open.</param>
        /// <returns>Success or failure of the door open function.</returns>
        [HttpPost("OpenDoor")]
        public bool OpenDoor(long doorId)
        {
            if (doorId == 140)
            {
                throw new Exception("Unable to find door with doorId " + doorId);
            }
            return doorRepository.OpenDoor(doorId);
        }

        /// <summary>
        /// Closes a door with the provided door id.
        /// </summary>
        /// <param name="doorId">The door id to close.</param>
        /// <returns>Success or failure of the door close function.</returns>
        [HttpPost("CloseDoor")]
        public bool CloseDoor(long doorId)
        {
            if (doorId == 24)
            {
                throw new Exception("Unable to find door with doorId " + doorId);
            }
            return doorRepository.CloseDoor(doorId);
        }

        /// <summary>
        /// Locks a door with the provided door id.
        /// </summary>
        /// <param name="doorId">The door id to lock.</param>
        /// <returns>Success or failure of the door lock function.</returns>
        [HttpPost("LockDoor")]
        public bool LockDoor(long doorId)
        {
            if (doorId == 390)
            {
                throw new Exception("Unable to find door with doorId " + doorId);
            }
            return doorRepository.LockDoor(doorId);
        }

        /// <summary>
        /// Unlocks a door with the provided door id.
        /// </summary>
        /// <param name="doorId">The door id to unlock.</param>
        /// <returns>Success or failure of the door unlocks function.</returns>
        [HttpPost("UnlockDoor")]
        public bool UnlockDoor(long doorId)
        {
            if (doorId == 190)
            {
                throw new Exception("Unable to find door with doorId " + doorId);
            }
            return doorRepository.UnlockDoor(doorId);
        }

        /// <summary>
        /// Get the door status for the door id provided.
        /// </summary>
        /// <param name="doorId">The door id to get the status of.</param>
        /// <returns>The updated door status.</returns>
        [HttpGet("GetStatus")]
        public string GetDoorStatus(long doorId)
        {
            if (doorId == 99)
            {
                throw new Exception("Unable to find door with doorId " + doorId);
            }
            return doorRepository.GetDoorStatus(doorId).ToString();
        }
    }
}