using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetSpike.Services.MonstersService
{
    public interface IMonstersService
    {
       Task<ServiceResponse<List<Monsters>>> GetAllMonsters();
        Task<ServiceResponse<Monsters>> GetSingle(int id);
        Task<ServiceResponse<List<Monsters>>> AddMonsters(Monsters newMonsters);
    }
}