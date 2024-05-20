using AutoMapper;
using DemoWebApi.Business.Mapper;
using DemoWebApiApps.Business.Services;
using DemoWebApiApps.ViewModels;

namespace DemoWebApiApps.Services
{
    public class UserAPIService : IUserAPIService
    {
        private readonly IUserService _userService;        
        public UserAPIService(IUserService userService)
        {
            _userService = userService;           
        }
        public async Task<IEnumerable<UserRequestModel>> GetAllUserList()
        {
            return ObjectMapper.Mapper.Map<IEnumerable<UserRequestModel>>(await _userService.GetAllUsers());           
        }
    }
}
