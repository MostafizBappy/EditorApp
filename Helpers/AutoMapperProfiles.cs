using AutoMapper;
using EditorApp.API.Dtos;
using EditorApp.API.Models;

namespace EditorApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<TblUser, UserForLoginDto>();
            CreateMap<Story, StoryForReturnDto>();
            CreateMap<StoryForReturnDto, Story>();
            CreateMap<DwEmployee, AuthorListDto>();
            CreateMap<View_StorySearch, StoryForReturnDto>();
            CreateMap<PhotoDto, PhotoSummary>();
        }
    }
}