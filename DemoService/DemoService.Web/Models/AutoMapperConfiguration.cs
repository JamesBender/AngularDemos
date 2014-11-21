using AutoMapper;
using DemoService.Web.Models.ViewModels;

namespace DemoService.Web.Models
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Album, Core.Album>();
            Mapper.CreateMap<Core.Album, Album>();
        }
    }
}