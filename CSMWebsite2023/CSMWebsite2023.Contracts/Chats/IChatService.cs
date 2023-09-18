using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.Chats
{
    public interface IChatService : IService
    {
        List<ChatDto>? GetChats();
    }
}
