using AutoMapper;
using MenuProject.Data;
using MenuProject.Dtos;
using MenuProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MenuProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {

        private readonly IMenuRepo _repository;
        private readonly IMapper _mapper;
        

        public MenusController(IMenuRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MenuReadDto>> GetMenus()
        {
            Console.WriteLine("--> Getting Platforms...");

            var menuItem = _repository.GetAllMenus();

            return Ok(_mapper.Map<IEnumerable<MenuReadDto>>(menuItem));
        }

        [HttpGet("id/{id}", Name = "GetMenuById")]
        
        public ActionResult<MenuReadDto> GetMenuById(int id)
        {
            Console.WriteLine("-> Getting Single platform");

            var platformItemById = _repository.GetMenuById(id);
            if (platformItemById != null)
            {
                return Ok(_mapper.Map<MenuReadDto>(platformItemById));
            }


            return NotFound();
            
        }

        [HttpGet("name/{name}", Name = "GetMenuByName")]

        public ActionResult<MenuReadDto> GetMenuByName(string name)
        {
            var menuItemByName = _repository.GetMenuByName(name);
            if (menuItemByName != null)
            {
                return Ok(_mapper.Map<MenuReadDto>(menuItemByName));
            }

            return NotFound();
          
        }
        

        [HttpPost]
        public ActionResult<MenuReadDto> CreateMenu(MenuCreateDto platformCreateDto)
        {
            Console.WriteLine("--> Attempting to create Platform");

            var createPlatform = _mapper.Map<Menu>(platformCreateDto);
            _repository.CreateMenu(createPlatform);
            _repository.SaveChanges();

            var platformReadDto = _mapper.Map<MenuReadDto>(createPlatform);

            return CreatedAtRoute(nameof(GetMenuById), new { Id = platformReadDto.Id }, platformReadDto);
        }

    }
}
