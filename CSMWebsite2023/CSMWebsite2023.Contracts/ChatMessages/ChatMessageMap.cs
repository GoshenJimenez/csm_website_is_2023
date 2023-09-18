using AutoMapper;
using CSMWebsite2023.Contracts.Users;
using CSMWebsite2023.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.ChatMessages
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<ChatMessage, ChatMessageDto>();
            CreateMap<ChatMessageDto, ChatMessage>();
        }
    }
}
