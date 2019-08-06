using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.DoorHomeworkAPI.Models
{
    public class Door
    {
        public long DoorId { get; set; }
        public string Name { get; set; }
        public long BuildingId { get; set; }
        public DoorStatus Status { get; set; }

    }

    public class Building
    {
        public long BuildingId { get; set; }
        public string Name { get; set; }
    }
}
