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

        public async Task<ServiceResponse<List<Monsters>>> AddMonsters(Monsters newMonsters)
        {
            var serviceResponse = new ServiceResponse<List<Monsters>>();
            monsters.Add(newMonsters);
            serviceResponse.Data = monsters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Monsters>>> GetAllMonsters()
        {
            return new ServiceResponse<List<Monsters>> {Data = monsters};
        }

        public async Task<ServiceResponse<Monsters>> GetSingle(int id)
        {
            var serviceResponse = new ServiceResponse<Monsters>();
            var monsters = monsters.FirstOrDefault(m => m.Id == id);
            serviceResponse.Data = monsters;
            return serviceResponse;
        }
    }
}