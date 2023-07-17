using AutoMapper;
using Patric_God.Models.ModelsDTO;

namespace Patric_God.Models.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() { 
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
