using AutoMapper;
using MenuProject.Dtos;
using MenuProject.Models;

namespace MenuProject.Profiles
{
    public class MenusProfile : Profile
    {
        public MenusProfile()
        {
            //CreateMap(Source(MODELS)  - > Target(DTO'S ))
            CreateMap<Menu, MenuReadDto>();
            CreateMap<MenuCreateDto, Menu>();
        }
    }
}
