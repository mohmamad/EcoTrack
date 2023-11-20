using EcoTrack.PL.Entities;
using EcoTrack.PL.Repositories.Users.Interface;

namespace EcoTrack.BL.MockedRepos
{
    internal class FakeUserRepository : IUserRepository
    {
        public Task AddUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserById(int id)
        {
            return
                await Task.Run(() =>
                    {
                        return new User
                        {
                           
                        };
                    });
        }
    }
}
