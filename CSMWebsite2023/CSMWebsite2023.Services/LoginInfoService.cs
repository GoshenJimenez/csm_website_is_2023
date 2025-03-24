using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Data.Models;
using CSMWebsite2023.Services.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSMWebsite2023.Contracts.LoginInfo;
using System.Net.Mail;

namespace CSMWebsite2023.Services
{
    public class LoginInfoService : BaseService, ILoginInfoService
    {
        private readonly IRepository<LoginInfo> _loginInfoRepository;
        public LoginInfoService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper,
              IRepository<LoginInfo> loginInfoRepository
            )
            : base(configuration, logger, mapper)
        {
            _loginInfoRepository = loginInfoRepository;
        }
        public List<LoginInfoDto>? GetPerUser(Guid? userId = null)
        {
            if (userId == null)
            {
                return null;
            }

            var query = _loginInfoRepository.All().Where(a => a.UserId == userId);

            return Mapper
            .Map<List<LoginInfoDto>>(query);
        }

        public LoginInfoDto? GetPassword(Guid? userId = null)
        {
            if (userId == null)
            {
                return null;
            }

            var query = _loginInfoRepository.All().FirstOrDefault(a => a.UserId == userId && a.Key != null && a.Key.ToLower() == "password");

            return Mapper.Map<LoginInfoDto?>(query);
        }

        public async Task<LoginInfoDto?> Update(LoginInfoDto? loginInfoDto)
        {
            if (loginInfoDto == null)
            {
                return null;
            }

            var loginInfo = _loginInfoRepository.All().FirstOrDefault(a => a.Id == loginInfoDto.Id);

            if(loginInfo != null)
            {
                loginInfo.Value = loginInfoDto.Value;
                loginInfo.UpdatedAt = DateTime.UtcNow;

                _loginInfoRepository.Update(loginInfo);
                await _loginInfoRepository.SaveChangesAsync();

                return loginInfoDto;
            }

            return null;
        }

        public LoginInfoDto? GetRole(Guid? userId)
        {
			if (userId == null)
			{
				return null;
			}

			var query = _loginInfoRepository.All().FirstOrDefault(a => a.UserId == userId && a.Key != null && a.Key.ToLower() == "role");

			return Mapper.Map<LoginInfoDto?>(query);
		}
	}
}
