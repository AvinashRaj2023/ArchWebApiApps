using AutoMapper;
using DemoWebApi.Common.Entities;
using DemoWebApiApps.Business.Models;
namespace DemoWebApi.Business.Mapper
{
    public class DemoWebApiAppDtoMapper : Profile
    {
        public DemoWebApiAppDtoMapper()
        {
            CreateMap<UserBAL, UserDto>().ReverseMap();                     
        }
    }
}
