using System.Linq;
using API.Dtos;
using API.Entity;
using API.Extensions;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>().ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).Url)).ForMember(dest => dest.Age, optSrc => optSrc.MapFrom(optSrc => optSrc.DateOfBirth.CalCulateAGe()));
            CreateMap<Photo, PhotoDto>();
        }
    }
}