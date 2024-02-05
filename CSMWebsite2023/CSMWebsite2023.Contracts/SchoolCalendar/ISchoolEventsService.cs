using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Contracts.SchoolEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.SchoolEvents
{
    public interface ISchoolEventService : IService
    {
        SchoolEventDto? GetSchoolEventById(Guid? id);


        Task<OperationDto<SchoolEventDto>>? Create(CreateDto? dto);
        Task<OperationDto<SchoolEventDto>>? Update(UpdateDto? dto);
        Task<OperationDto<SchoolEventDto>>? Delete(ActivationDto? dto);
        Task<OperationDto<SchoolEventDto>>? Restore(ActivationDto? dto);
        Task<Paged<SchoolEventDto>>? Search(bool? isActive = true, int? pageIndex = 1, int? pageSize = 10, string? keyword = "");
    }
}
