using EcoTrack.PL.Entities;
using EcoTrack.PL.Repositories.Users.Interface;

namespace EcoTrack.BL.Services
{
    //Example
    public class UsersService
    {
        private readonly IUserRepository _userRepository;
        public UsersService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }
        public async Task AddUserAsync(User user)
        {
            await _userRepository.AddUserAsync(user);
        }
    }
}
