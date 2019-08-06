using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.DoorHomeworkAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Data.DoorHomeworkAPI.Controllers
{
    public class DoorController : Controller
    {
        private readonly IDoorRepository doorRepository;

        public DoorController(IDoorRepository doorRepo)
        {
            doorRepository = doorRepo;
        }

        [HttpGet("Index")]
        public string Index() => "This is from the door controller";
    }
}