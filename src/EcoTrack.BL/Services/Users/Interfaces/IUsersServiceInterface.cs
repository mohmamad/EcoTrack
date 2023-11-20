using EcoTrack.PL.Entities;

namespace EcoTrack.BL.Services.Users.Interfaces
{
    public interface IUsersServiceInterface
    {
        public Task<User> GetUserById(int id);
    }
}
