using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetSpike.Services.MonstersService;
using Microsoft.AspNetCore.Mvc;

namespace dotnetSpike.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonstersController : ControllerBase
    {
        private readonly IMonstersService _monstersService;
        public MonstersController(IMonstersService monstersService)
        {
            _monstersService = monstersService;
        }

        // private static Monsters fire = new Monsters();
        
        [HttpGet("GetAll")]
        public ActionResult<List<Monsters>> GetAllMonsters()
        {
            return Ok(_monstersService.GetAllMonsters());
        }

        [HttpGet("{id}")]
        public ActionResult<Monsters> GetSingle(int id)
        {
            return Ok(_monstersService.GetSingle(id));
        }

        [HttpPost]
        public ActionResult<List<Monsters>> AddMonsters(Monsters newMonsters)
        {
            // monsters.Add(newMonster);
            return Ok(_monstersService.AddMonsters(newMonsters));
        }
    }
}