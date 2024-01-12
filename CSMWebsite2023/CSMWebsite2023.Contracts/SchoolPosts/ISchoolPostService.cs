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

        Task<OperationDto<SchoolPostDto>>? Create(CreateDto? dto);
        Task<OperationDto<SchoolPostDto>>? Update(UpdateDto? dto);
        Task<OperationDto<SchoolPostDto>>? Delete(ActivationDto? dto);
        Task<OperationDto<SchoolPostDto>>? Restore(ActivationDto? dto);
        Task<Paged<SchoolPostDto>>? Search(bool? isActive = true, int? pageIndex = 1, int? pageSize = 10, string? keyword = "");
    }
}
