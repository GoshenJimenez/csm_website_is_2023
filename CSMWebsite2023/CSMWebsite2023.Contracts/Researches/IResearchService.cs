using CSMWebsite2023.Contracts.Chats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.Researches
{
    public interface IResearchService : IService
    {
        List<ResearchDto>? GetResearches();
        ResearchDto? GetResearchById(Guid? id);
    }
}
