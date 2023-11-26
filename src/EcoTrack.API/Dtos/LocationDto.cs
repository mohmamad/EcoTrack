using System.ComponentModel.DataAnnotations;

namespace EcoTrack.API.Dtos
{
    #nullable disable
    public class LocationDto
    {
        [Required]
        public string CityName { get; set; }
        [Required]
        public string CountryName { get; set; }
    }
}