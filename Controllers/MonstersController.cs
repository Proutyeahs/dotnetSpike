using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnetSpike.Models
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonstersController : ControllerBase
    {
        private static Monsters fire = new Monsters();

        public IActionResult Get()
        {
            return Ok(fire);
        }
    }
}