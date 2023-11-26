using AutoMapper;
using EcoTrack.API.Dtos;
using EcoTrack.PL.Entities;

namespace EcoTrack.API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<User, UserDtoForUpdate>();
            CreateMap< UserDtoForUpdate, User>();
        }
    }
}
