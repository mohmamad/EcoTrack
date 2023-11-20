namespace EcoTrack.API.Dtos
{
#nullable disable
    public class UserDto
    {
        public string Username { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Email { get; set; } 
        public LocationDto Location { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Deleted { get; set; }

    }
}
