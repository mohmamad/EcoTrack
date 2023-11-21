using AutoMapper;
using EcoTrack.API.Dtos;
using EcoTrack.PL.Entities;

namespace EcoTrack.API.Profiles
{
    public class UserRegistrationProfile : Profile
    {
        public UserRegistrationProfile() 
        {
            CreateMap<UserRegistrationDto, User>();
        }
    }
}
