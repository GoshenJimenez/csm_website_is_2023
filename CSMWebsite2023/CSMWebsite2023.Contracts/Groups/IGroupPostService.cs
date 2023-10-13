using CSMWebsite2023.Contracts.Chats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.GroupPost
{
    public interface IGroupPostService : IService
    {
        List<GroupPostDto>? GetGroupPost();
        GroupPostDto? GetGroupPostById(Guid? id);
    }
}
