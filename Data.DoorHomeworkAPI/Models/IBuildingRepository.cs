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
    }
}
