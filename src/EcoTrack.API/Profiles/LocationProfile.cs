using AutoMapper;
using EcoTrack.API.Dtos;
using EcoTrack.PL.Entities;

namespace EcoTrack.API.Profiles
{
    public class LocationProfile : Profile
    {
        public LocationProfile()
        {
            CreateMap<Location, LocationDto>();
        }
    }
}
