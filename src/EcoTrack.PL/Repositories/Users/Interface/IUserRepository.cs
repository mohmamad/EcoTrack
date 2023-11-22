using EcoTrack.PL.Entities;

namespace EcoTrack.PL.Repositories.Users.Interface
{
    public interface IUserRepository
    {
        public Task AddUserAsync(User user);
        public Task<User?> GetUserById(int id);
        public Task<bool> IsFoundByUsernameAsync(string username);
        public Task<IEnumerable<User>> GetAllUsersAsync(string? firstName, string? lastName, string? cityName, string? countryName, int pageSize, int page);
        public Task<bool> SaveChangesAsync();
    }
}
