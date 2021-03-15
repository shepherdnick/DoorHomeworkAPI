using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.DoorHomeworkAPI.Models
{
    /// <summary>
    /// A class representing a door 
    /// </summary>
    public class Door
    {
        /// <summary>
        /// The door ID
        /// </summary>
        public long DoorId { get; set; }

        /// <summary>
        /// The door name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The building ID that the door belongs to
        /// </summary>
        public long BuildingId { get; set; }

        /// <summary>
        /// The status of the door
        /// </summary>
        public DoorStatus Status { get; set; }

        private int TempChange { get; set; }
    }    
}
