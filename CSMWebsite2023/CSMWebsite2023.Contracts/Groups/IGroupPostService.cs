
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.GroupPosts
{
    public interface IGroupPostService : IService
    {
        List<GroupPostDto>? GetGroupPost();
        GroupPostDto? GetGroupPostById(Guid? id);
        Task<CreateDto>? Create(CreateDto? dto);
    }
}
