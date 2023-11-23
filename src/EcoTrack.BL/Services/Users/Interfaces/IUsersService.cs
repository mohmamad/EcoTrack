using EcoTrack.PL.Entities;

namespace EcoTrack.BL.Services.Users.Interfaces
{
    public interface IUsersService
    {
        public Task<User?> GetUserByIdAsync(int id);
        public Task AddUserAsync(User user);
        public Task<IEnumerable<User>> GetAllUsersAsync( 
            string? firstName,
            string? lastName,
            string? cityName,
            string? countryName,
            int pageSize,
            int page
            );
        public Task<bool> SaveChangesAsync();
        public Task DeleteUserAsync(long id);
    }
}
