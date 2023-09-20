using AutoMapper;
using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.ChatMessages;
using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Data.Models;
using CSMWebsite2023.Services.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CSMWebsite2023.Services
{
    public class ChatMessageService : BaseService, IChatMessageService
    {
        private readonly IRepository<ChatMessage> _chatMessageRepository;
        private readonly IRepository<ChatMedium> _chatMediaRepository;
        public ChatMessageService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper,
              IRepository<ChatMessage> chatMessageRepository,
              IRepository<ChatMedium> chatMediaRepository
            )
            : base(configuration, logger, mapper)
        {
            _chatMessageRepository = chatMessageRepository;
            _chatMediaRepository = chatMediaRepository;
        }

        public ChatMessageDto? GetChatMessage(Guid? id)
        {
            var query = _chatMessageRepository.All()
                    .Include(a => a.User)
                    .Include(a => a.Chat)
                    .FirstOrDefault(a => a.Id == id);

            var result = Mapper.Map<ChatMessageDto>(query);

            var media = _chatMediaRepository.All().Where(a => a.ChatMessageId == id).ToList();

            result.ChatMedia = media;

            return result;
        }

    }
}
