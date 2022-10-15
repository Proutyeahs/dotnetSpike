using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnetSpike.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonstersController : ControllerBase
    {

        private static List<Monsters> monsters = new List<Monsters> {
            new Monsters(),
            new Monsters {Id = 1, Name = "Tom"}
        };
        private static Monsters fire = new Monsters();

        
        [HttpGet("GetAll")]
        public ActionResult<List<Monsters>> Get()
        {
            return Ok(monsters);
        }

        [HttpGet("{id}")]
        public ActionResult<Monsters> GetSingle(int id)
        {
            return Ok(monsters.FirstOrDefault(m => m.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Monsters>> AddMonster(Monsters newMonster)
        {
            monsters.Add(newMonster);
            return Ok(monsters);
        }
    }
}