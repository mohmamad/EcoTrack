using EcoTrack.BL.Exceptions;
using EcoTrack.BL.Services.Users.Interfaces;
using EcoTrack.PL.Entities;
using EcoTrack.PL.Repositories.Users.Interface;
using System.Security.Cryptography;
using System.Text;

namespace EcoTrack.BL.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly IUserRepository _userRepository;
        public UsersService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        private static string HashPassword(string input)
        {
            var hasher = SHA256.Create();
            var hashedPassword =  hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Encoding.UTF8.GetString(hashedPassword);
        }

        public async Task AddUserAsync(User user)
        {
           var found= await _userRepository.IsFoundByUsernameAsync(user.Username);
            if (found)
            {
                throw new UsernameUsedException($"{user.Username} already used.");
            }
            user.Password= HashPassword(user.Password);
            await _userRepository.AddUserAsync(user);
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserById(id);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(
            string? firstName,
            string? lastName,
            string? cityName,
            string? countryName,
            int pageSize,
            int page)
        {
            pageSize = Math.Min(pageSize, 30);
            return await _userRepository.GetAllUsersAsync( 
                firstName?.ToLower(),
                lastName?.ToLower(),
                cityName?.ToLower(),
                countryName?.ToLower(),
                pageSize,
                page);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _userRepository.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(long id)
        {
            var isFound = await _userRepository.IsFoundByUserIdAsync(id);
            if (!isFound)
            {
                throw new NotFoundUserException($"User with {id} id not found.");
            }
            await _userRepository.DeleteUserAsync(id);
        }

        public Task<User?> GetUserByCredentials(string username, string password)
        {
            var hashedPassword = HashPassword(password);
            var user = _userRepository.GetUserByCredentials(username, hashedPassword);
            return user;
        }
    }
}
