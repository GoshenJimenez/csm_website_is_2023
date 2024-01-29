using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Contracts.Researches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.SchoolAds
{
    public interface ISchoolAdService : IService
    {
        Task<OperationDto<SchoolAdDto>>? Create(CreateDto? dto);
        Task<OperationDto<SchoolAdDto>>? Update(UpdateDto? dto);
        Task<OperationDto<SchoolAdDto>>? Delete(ActivationDto? dto);
        Task<OperationDto<SchoolAdDto>>? Restore(ActivationDto? dto);
        Task<Paged<SchoolAdDto>>? Search(bool? isActive = true, int? pageIndex = 1, int? pageSize = 10, string? keyword = "");
        object GetSchoolAdsById(Guid? id);
    }
}
