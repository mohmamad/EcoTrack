using AutoMapper;
using EcoTrack.API.Dtos;
using EcoTrack.BL.Services.Users;
using EcoTrack.BL.Services.Users.Interfaces;
using EcoTrack.PL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EcoTrack.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;
        private readonly IMapper _mapper;
        private readonly ILogger<UsersController> _logger;  
        public UsersController(
            IUsersService usersService,
            IMapper mapper,
            ILogger<UsersController> logger
            ) 
        {
            _usersService = usersService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<UserDto>> GetUserById(int userId)
        {
            var user = await _usersService.GetUserById(userId);

            if(user == null) 
            {
                return NotFound();
            }

            var userDto = _mapper.Map<UserDto>(user);

            return Ok(userDto);
        }
    }
}
