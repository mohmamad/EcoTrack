namespace EcoTrack.API.Dtos
{
#nullable disable
    public class UserDto
    {
        public string Username { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Email { get; set; } 
        public string CountryName { get; set; } 
        public string CityName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Deleted { get; set; }

    }
}
