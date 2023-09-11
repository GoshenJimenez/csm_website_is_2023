using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.Chats;
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

namespace CSMWebsite2023.Services
{
    public class ChatService : BaseService, IChatService
    {
        private readonly IRepository<Chat> _chatRepository;
        public ChatService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper,
              IRepository<Chat> chatRepository
            )
            : base(configuration, logger, mapper)
        {
            _chatRepository = chatRepository;
        }
        public List<ChatDto>? GetChats()
        {
            var query = _chatRepository.All();

            return Mapper
            .Map<List<ChatDto>>(query);
        }
    }
}
