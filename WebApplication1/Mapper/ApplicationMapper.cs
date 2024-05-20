using AutoMapper;
using DemoWebApiApps.Business.Models;
using DemoWebApiApps.ViewModels;

namespace DemoWebApiApps.Mapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<UserRequestModel, UserBAL>().ReverseMap();
            //CreateMap<UserBAL, UserRequestModel>();
        }
    }
}
