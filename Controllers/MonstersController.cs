using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetSpike.Services.MonstersService;
using Microsoft.AspNetCore.Mvc;
using dotnetSpike.Dtos.Monsters;

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
        public async Task<ActionResult<ServiceResponse<List<GetMonstersDto>>>> GetAllMonsters()
        {
            return Ok(await _monstersService.GetAllMonsters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetMonstersDto>>> GetSingle(int id)
        {
            return Ok(await _monstersService.GetSingle(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetMonstersDto>>>> AddMonsters(AddMonstersDto newMonsters)
        {
            // monsters.Add(newMonster);
            return Ok( await _monstersService.AddMonsters(newMonsters));
        }
    }
}