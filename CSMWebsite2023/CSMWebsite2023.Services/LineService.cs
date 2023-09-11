using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.Users;
using CSMWebsite2023.Data.Models;
using CSMWebsite2023.Services.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Eos.Services
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
    }
}
