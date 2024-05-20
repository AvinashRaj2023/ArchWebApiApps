using DemoWebApi.Common.Entities;
using DemoWebApi.Common.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApi.Common.Repositories
{
    public interface IUserRepository :IRepository<UserDto>
    {
        Task<IEnumerable<UserDto>> GetUsers();
    }
}
