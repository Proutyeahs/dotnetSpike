using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetSpike.Dtos.Monsters
{
    public class AddMonstersDto
    
    {
        public string Name {get; set;} = "T-Rex";

        public int HitPoints {get; set;} = 100;

        public int Attack {get; set;} = 10;

        public int Defense {get; set;} = 10;
        
        public MonsterType Class {get; set;} = MonsterType.Fire;
    }
}