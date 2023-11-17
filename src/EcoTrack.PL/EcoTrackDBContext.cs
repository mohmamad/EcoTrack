using EcoTrack.PL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcoTrack.PL
{
    public class EcoTrackDBContext : DbContext
    {
        public EcoTrackDBContext()
        {
        }
        public EcoTrackDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }  
        public DbSet<User> Users { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql("server=localhost;database=EcoTrackDB;user=root;password=;"
        //        ,ServerVersion.AutoDetect("server=localhost;database=EcoTrackDB;user=root;password=;"));
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        public void Seeding(ModelBuilder mb)
        {

        }
    }
}
