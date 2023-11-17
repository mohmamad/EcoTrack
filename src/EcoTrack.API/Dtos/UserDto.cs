using System.ComponentModel.DataAnnotations;

namespace EcoTrack.API.Dtos
{
    public class UserDto
    {
        [Required]
        public string Name { get; set; }
    }
}
