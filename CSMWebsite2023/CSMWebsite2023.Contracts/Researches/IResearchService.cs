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
        ResearchDto? GetResearchById(Guid? id);


        Task<OperationDto<ResearchDto>>? Create(CreateDto? dto);
        Task<OperationDto<ResearchDto>>? Update(UpdateDto? dto);
        Task<OperationDto<ResearchDto>>? Delete(ActivationDto? dto);
        Task<OperationDto<ResearchDto>>? Restore(ActivationDto? dto);
    }
}
