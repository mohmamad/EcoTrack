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


        public async Task<User?> GetUserById(int id)
        {
            return    
            await _dbContext.Users
                .Include(u=>u.Location)
                .Where(u => u.UserId == id)
                .FirstOrDefaultAsync();
        }

        public async Task<bool> IsFoundByUsernameAsync(string username)
        {
            return await _dbContext.Users.AnyAsync(u=> u.Username == username);
        }

        public async Task AddUserAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();    
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(
            string? firstName,
            string? lastName,
            string? cityName,
            string? countryName,
            int pageSize,
            int page)
        {
            IQueryable<User> userQuery = _dbContext.Users.Include(u=> u.Location);

            if(firstName != null)
            {
               userQuery= userQuery.Where(u => u.FirstName.ToLower() == firstName);
            }
            if(lastName != null)
            {
                userQuery = userQuery.Where(u=> u.LastName.ToLower() == lastName);    
            }
            if(cityName != null)
            {
                userQuery = userQuery.Where(u=> u.Location.CityName.ToLower() == cityName);
            }
            if(countryName != null) 
            {
                userQuery = userQuery.Where(u=> u.Location.CountryName.ToLower() == countryName);
            }

            return await userQuery
                .Skip((page-1)*pageSize)
                .Take(pageSize)
                .ToListAsync();

        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
