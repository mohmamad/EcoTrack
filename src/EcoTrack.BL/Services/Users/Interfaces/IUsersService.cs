using EcoTrack.PL.Entities;

namespace EcoTrack.BL.Services.Users.Interfaces
{
    public interface IUsersService
    {
        public Task<User?> GetUserById(int id);
        public Task AddUser(User user);
    }
}
