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

        public async Task<List<Monsters>> AddMonsters(Monsters newMonsters)
        {
            monsters.Add(newMonsters);
            return monsters;
        }

        public async Task<List<Monsters>> GetAllMonsters()
        {
            return monsters;
        }

        public async Task<Monsters> GetSingle(int id)
        {
            return monsters.FirstOrDefault(m => m.Id == id);
        }
    }
}