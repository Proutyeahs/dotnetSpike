using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetSpike.Services.MonstersService
{
    public interface IMonstersService
    {
        List<Monsters> GetAllMonsters();
        Monsters GetSingle(int id);
        List<Monsters> AddMonsters(Monsters newMonsters);
    }
}