using EcoTrack.PL.Entities;
using EcoTrack.PL.Repositories.Users.Interface;
using Microsoft.EntityFrameworkCore;

namespace EcoTrack.PL.Repositories.Users
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly EcoTrackDBContext _dbContext;
        public SqlUserRepository(EcoTrackDBContext dBContext) 
        {
            _dbContext = dBContext;
        }

        public async Task AddUserAsync(User user)
        {
           await _dbContext.Users.AddAsync(user);
        }

        public async Task<User?> GetUserById(int id)
        {
            return    
            await _dbContext.Users
                .Include(u=>u.Location)
                .Where(u => u.UserId == id)
                .FirstOrDefaultAsync();
        }
    }
}
