using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.DoorHomeworkAPI.Models
{
    /// <summary>
    /// Interface representing a building repository
    /// </summary>
    public interface IBuildingRepository
    {
        /// <summary>
        /// Gets a list of buildings
        /// </summary>
        /// <returns>A list of buildings</returns>
        IEnumerable<Building> GetBuildings();

        /// <summary>
        /// Adds a building to the repository
        /// </summary>
        /// <param name="building">The building to add</param>
        void AddBuilding(Building building);

        /// <summary>
        /// Removes a building from the repository
        /// </summary>
        /// <param name="buildingId">The id of the building to remove</param>
        void RemoveBuilding(long buildingId);
    }
}
