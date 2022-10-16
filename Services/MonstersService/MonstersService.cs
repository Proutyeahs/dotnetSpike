using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetSpike.Services.MonstersService
{
    public class MonstersService : IMonstersService
    {
        private static List<Monsters> monsters = new List<Monsters> {
            new Monsters(),
            new Monsters {Id = 1, Name = "Tom"}
        };

        public List<Monsters> AddMonsters(Monsters newMonsters)
        {
            monsters.Add(newMonsters);
            return monsters;
        }

        public List<Monsters> GetAllMonsters()
        {
            return monsters;
        }

        public Monsters GetSingle(int id)
        {
            return monsters.FirstOrDefault(m => m.Id == id);
        }
    }
}