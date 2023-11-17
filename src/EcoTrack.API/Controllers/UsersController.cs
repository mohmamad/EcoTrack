using AutoMapper;
using EcoTrack.API.Dtos;
using EcoTrack.BL.Services;
using EcoTrack.PL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EcoTrack.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly UsersService _usersService;
        private readonly IMapper _mapper;
        private readonly ILogger<UsersController> _logger;  
        public UsersController(
            UsersService usersService,
            IMapper mapper,
            ILogger<UsersController> logger
            ) 
        {
            _usersService = usersService;
            _mapper = mapper;
            _logger = logger;
        }    
        [HttpPost]
        public async Task<IActionResult> AddUser(UserDto userDto)
        {
            var user = _mapper.Map<UserDto, User>(userDto);

            await _usersService.AddUserAsync(user);

            return Ok(user);
        }
    }
}
