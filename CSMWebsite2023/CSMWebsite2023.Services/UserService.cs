using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.Users;
using CSMWebsite2023.Data.Models;
using CSMWebsite2023.Services.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CSMWebsite2023.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly IRepository<User> _userRepository;
        public UserService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper,
              IRepository<User> userRepository
            )
            : base(configuration, logger, mapper)
        {
            _userRepository = userRepository;
        }
        public List<UserDto>? GetUsers()
        {
            var query = _userRepository.All();

            return Mapper
            .Map<List<UserDto>>(query);
        }

        public UserDto? GetUserByEmail(string? emailAddress = null)
        {
            if (emailAddress == null)
            {
                return null;
            }

            var query = _userRepository.All().FirstOrDefault(a => a.EmailAddress != null && a.EmailAddress.ToLower() == emailAddress!.ToLower());

            return Mapper.Map<UserDto?>(query);
        }

        public UserDto? GetUserById(Guid? id)
        {
			if (id == null)
			{
				return null;
			}

			var query = _userRepository.All().FirstOrDefault(a => a.Id != null && a.Id == id);

			return Mapper.Map<UserDto?>(query);
		}

        public UserDto? UpdateUserProfile(UserDto? userDto)
        {
            if (userDto == null)
            {
                return null;
            }

            if (userDto.Id == null || string.IsNullOrEmpty(userDto.FirstName) || string.IsNullOrEmpty(userDto.LastName))
            {
				return null;
			}

			var user = _userRepository.All().FirstOrDefault(a => a.Id != null && a.Id == userDto.Id);

            if (user != null)
            {
                user.FirstName = userDto.FirstName;
                user.LastName = userDto.LastName;

                _userRepository.Update(user);

				return Mapper.Map<UserDto?>(user); 
            }

            return null;
		}
	}
}
