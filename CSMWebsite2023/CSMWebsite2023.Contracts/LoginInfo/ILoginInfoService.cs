using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSMWebsite2023.Contracts;

namespace CSMWebsite2023.Contracts.LoginInfo
{
    public interface ILoginInfoService : IService
    {
        List<LoginInfoDto>? GetPerUser(Guid? userId);

        LoginInfoDto? GetPassword(Guid? userId);

        Task<LoginInfoDto?> Update(LoginInfoDto? loginInfoDto);

        Task<OperationDto<LoginInfoDto?>?> ChangePassword(ChangePasswordDto? changePasswordDto);

        LoginInfoDto? GetRole(Guid? userId);
	}
}
