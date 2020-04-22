using AutoMapper;
using NNT_Backend.Entities;
using NNT_Backend.Models.Users;

namespace NNT_Backend.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}