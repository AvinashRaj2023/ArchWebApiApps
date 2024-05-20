using DemoWebApi.Common.Entities;
using DemoWebApiApps.Data.Data;
using DemoWebApiApps.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApi.Common.Repositories
{
    public class UserRepository : Repository<UserDto>, IUserRepository
    {
        public UserRepository(ApplicationContext dbContext):base(dbContext) { }
        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            try
            {
                return await GetAllAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
