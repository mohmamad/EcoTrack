using EcoTrack.BL.Services.Users.Interfaces;
using EcoTrack.PL.Entities;
using EcoTrack.PL.Repositories.Users.Interface;

namespace EcoTrack.BL.Services.Users
{
    //Example
    public class UsersService : IUsersServiceInterface
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

        public async Task<User> GetUserById(int id)
        {

            return await _userRepository.GetUserById(id);
        }
    }
}
