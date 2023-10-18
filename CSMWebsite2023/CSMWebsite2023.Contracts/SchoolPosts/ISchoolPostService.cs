using CSMWebsite2023.Contracts.Chats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.SchoolPosts
{
    public interface ISchoolPostService : IService
    {
        SchoolPostDto? GetSchoolPostById(Guid? id);

        Task<CreateDto>? Create(CreateDto? dto);
    }
}
