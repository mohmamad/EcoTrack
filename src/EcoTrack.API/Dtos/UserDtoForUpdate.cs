using System.ComponentModel.DataAnnotations;

namespace EcoTrack.API.Dtos
{
    public class UserDtoForUpdate
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public LocationDto Location { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
