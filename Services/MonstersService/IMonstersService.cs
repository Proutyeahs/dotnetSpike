using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetSpike.Services.MonstersService
{
    public interface IMonstersService
    {
       Task<List<Monsters>> GetAllMonsters();
        Task<Monsters> GetSingle(int id);
        Task<List<Monsters>> AddMonsters(Monsters newMonsters);
    }
}