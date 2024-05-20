using AutoMapper;
using DemoWebApi.Business.Mapper;
using DemoWebApi.Common.Repositories;
using DemoWebApiApps.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApiApps.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;        
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;           
        }
        public async Task<IEnumerable<UserBAL>> GetAllUsers()
        {
            var users=await _userRepository.GetAllAsync();
            var mapped=ObjectMapper.Mapper.Map<IEnumerable<UserBAL>>(users);
            return mapped;
        }
    }
}
