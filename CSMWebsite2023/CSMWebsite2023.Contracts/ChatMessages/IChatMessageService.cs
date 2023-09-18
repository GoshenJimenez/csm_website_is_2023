using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.ChatMessages
{
    public interface IChatMessageService : IService
    {
        //List<ChatMessageDto>? GetChatMessages();

        ChatMessageDto? GetChatMessage(Guid? id);
    }
}
