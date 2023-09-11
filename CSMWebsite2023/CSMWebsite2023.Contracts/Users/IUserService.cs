using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.Users
{
    public interface IUserService : IService
    {
        List<UserDto>? GetUsers();  
    }
}
