using DemoWebApi.Common.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApi.Common.Entities
{
    public class UserDto : Entity
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
