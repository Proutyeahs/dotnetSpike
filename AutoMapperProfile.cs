using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnetSpike.Dtos.Monsters;

namespace dotnetSpike
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile(){
            CreateMap<Monsters, GetMonstersDto>();
            CreateMap<AddMonstersDto, Monsters>();
        }
    }
}