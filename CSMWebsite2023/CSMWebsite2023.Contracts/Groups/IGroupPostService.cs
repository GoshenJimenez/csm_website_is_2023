
using CSMWebsite2023.Contracts.GroupPosts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Contracts.GroupPosts
{
    public interface IGroupPostService : IService
    {
        Task<OperationDto<GroupPostDto>>? Create(CreateDto? dto);
        Task<OperationDto<GroupPostDto>>? Update(UpdateDto? dto);
        Task<OperationDto<GroupPostDto>>? Delete(ActivationDto? dto);
        Task<OperationDto<GroupPostDto>>? Restore(ActivationDto? dto);
        Task<Paged<GroupPostDto>>? Posts(bool? isActive = true, int? pageIndex = 1, int? pageSize = 10, string? keyword = "");
        object GetGroupPostById(Guid? id);
    }
}
