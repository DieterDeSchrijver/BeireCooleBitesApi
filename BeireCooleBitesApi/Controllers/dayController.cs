using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using BeireCooleBitesApi.Models;
using Microsoft.AspNetCore.Cors;

namespace BeireCooleBitesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DayController : ControllerBase
    {
        private DayRepo _dayRepo;
        
        public DayController()
        {
            _dayRepo = new DayRepo();
        }

        [EnableCors]
        [HttpGet("allDays")]
        public List<Day> Get()
        {
            return _dayRepo.getAll();
        }
        
        [EnableCors]
        [HttpPut("addPerson")]
        public string AddPerson(string name, string day)
        {
            _dayRepo.AddPerson(name,day);
            return "200 OK";
        }
        
        
    }
}
