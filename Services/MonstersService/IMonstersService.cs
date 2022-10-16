using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetSpike.Dtos.Monsters;

namespace dotnetSpike.Services.MonstersService
{
    public interface IMonstersService
    {
       Task<ServiceResponse<List<GetMonstersDto>>> GetAllMonsters();
        Task<ServiceResponse<GetMonstersDto>> GetSingle(int id);
        Task<ServiceResponse<List<GetMonstersDto>>> AddMonsters(AddMonstersDto newMonsters);
    }
}