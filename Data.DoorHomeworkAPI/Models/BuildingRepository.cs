using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.DoorHomeworkAPI.Models
{
    /// <summary>
    /// An in memory building repository
    /// </summary>
    public class BuildingRepository : IBuildingRepository
    {
        private Dictionary<long, Building> buildings;

        /// <summary>
        /// Constructor for a building repository
        /// </summary>
        public BuildingRepository()
        {
            buildings = new Dictionary<long, Building>();
            new List<Building>
            {
                new Building { BuildingId=1, Name="BLD001"},
                new Building { BuildingId=2, Name="BLD002"},
                new Building { BuildingId=3, Name="BLD003"},
                new Building { BuildingId=4, Name="BLD004"},
                new Building { BuildingId=5, Name="BLD005"},
                new Building { BuildingId=16, Name="Hawthorne House"},
                new Building { BuildingId=17, Name="Chestnut House"},
                new Building { BuildingId=18, Name="Bay House"},
                new Building { BuildingId=19, Name="Compass House"},
                new Building { BuildingId=20, Name="Davies House"},
                new Building { BuildingId=31, Name="Primrose House"},
                new Building { BuildingId=32, Name="Redwood Court"},
                new Building { BuildingId=33, Name="Mercure House"},
                new Building { BuildingId=34, Name="Bassett's House"},
                new Building { BuildingId=35, Name="Sinclair House"},
                new Building { BuildingId=606, Name="Roland Court"},
                new Building { BuildingId=404, Name="Unknown"},
                new Building { BuildingId=909, Name="Fulton House"},
                new Building { BuildingId=910, Name="Faraday Tower"},
                new Building { BuildingId=911, Name="Singleton Library"}
            }.ForEach(b => buildings[b.BuildingId] = b);
        }

        /// <summary>
        /// Gets a list of buildings from the repository
        /// </summary>
        /// <returns>A list of buildings</returns>
        public IEnumerable<Building> GetBuildings()
        {
            return buildings.Values;
        }
    }
}
