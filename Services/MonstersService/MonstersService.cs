using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetSpike.Dtos.Monsters;
using AutoMapper;

namespace dotnetSpike.Services.MonstersService
{
    public class MonstersService : IMonstersService
    {
        private static List<Monsters> monsters = new List<Monsters> {
            new Monsters(),
            new Monsters {Id = 1, Name = "Tom"}
        };

        private readonly IMapper _mapper;

        public MonstersService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetMonstersDto>>> AddMonsters(AddMonstersDto newMonsters)
        {
            var serviceResponse = new ServiceResponse<List<GetMonstersDto>>();
            monsters.Add(_mapper.Map<Monsters>(newMonsters));
            serviceResponse.Data = monsters.Select(m => _mapper.Map<GetMonstersDto>(m)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetMonstersDto>>> GetAllMonsters()
        {
            return new ServiceResponse<List<GetMonstersDto>> {Data = monsters.Select(m => _mapper.Map<GetMonstersDto>(m)).ToList()};
        }

        public async Task<ServiceResponse<GetMonstersDto>> GetSingle(int id)
        {
            var serviceResponse = new ServiceResponse<GetMonstersDto>();
            var monster = monsters.FirstOrDefault(m => m.Id == id);
            serviceResponse.Data = _mapper.Map<GetMonstersDto>(monster);
            return serviceResponse;
        }
    }
}