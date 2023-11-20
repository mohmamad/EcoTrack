using EcoTrack.BL.Services.Users.Interfaces;
using EcoTrack.PL.Entities;
using EcoTrack.PL.Repositories.Users.Interface;

namespace EcoTrack.BL.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly IUserRepository _userRepository;
        public UsersService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> GetUserById(int id)
        {
            return await _userRepository.GetUserById(id);
        }
    }
}
