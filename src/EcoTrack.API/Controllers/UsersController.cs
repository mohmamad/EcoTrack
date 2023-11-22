using AutoMapper;
using EcoTrack.API.Dtos;
using EcoTrack.BL.Exceptions;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAllUsers(
            [FromQuery] string? firstName,
            [FromQuery] string? lastName,
            [FromQuery] string? cityName,
            [FromQuery] string? countryName,
            [FromQuery] int pageSize = 30,
            [FromQuery] int page= 1
            )
        {
            //TODO-POLICY:retrieve just followed user.??X
            //TODO-POLICY:Admin can get all.

            var users = await _usersService.GetAllUsersAsync(firstName, lastName, cityName, countryName, pageSize, page);
            var usersDto = _mapper.Map<IEnumerable<UserDto>>( users );

            return Ok( usersDto );
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<UserDto>> GetUserById(int userId)
        {
            var user = await _usersService.GetUserByIdAsync(userId);

            if(user == null) 
            {
                return NotFound();
            }

            var userDto = _mapper.Map<UserDto>(user);

            return Ok(userDto);
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> AddUser(UserRegistrationDto userRegistrationDto)
        {
            //TODO: add validation attributes on the UserRegistrationDto
            var user = _mapper.Map<User>(userRegistrationDto);
            try
            {
                await _usersService.AddUserAsync(user);
            }
            catch(UsernameUsedException e)
            {
                return Conflict(new
                                    {
                                        message= e.Message
                                    });
            }
            catch(Exception e)
            {
                _logger.LogError(e, "Error on adding a user");
                return StatusCode(500, "Internal Server Error.");
            }
            return NoContent();
        }
    }
}
