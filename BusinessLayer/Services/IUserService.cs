﻿using DemoWebApiApps.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApiApps.Business.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserBAL>> GetAllUsers();
    }
}
