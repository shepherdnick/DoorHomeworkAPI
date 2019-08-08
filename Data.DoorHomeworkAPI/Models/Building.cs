using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.DoorHomeworkAPI.Models
{
    /// <summary>
    /// A class representing a building
    /// </summary>
    public class Building
    {
        /// <summary>
        /// Building ID
        /// </summary>
        public long BuildingId { get; set; }
        /// <summary>
        /// Building Name
        /// </summary>
        public string Name { get; set; }
    }
}
