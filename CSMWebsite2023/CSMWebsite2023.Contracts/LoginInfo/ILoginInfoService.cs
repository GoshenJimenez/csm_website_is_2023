using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.LoginInfo
{
    public interface ILoginInfoService : IService
    {
        List<LoginInfoDto>? GetPerUser(Guid? userId);

        LoginInfoDto? GetPassword(Guid? userId);
    }
}
