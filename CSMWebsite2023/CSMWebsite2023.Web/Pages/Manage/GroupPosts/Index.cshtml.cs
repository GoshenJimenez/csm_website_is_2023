using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.GroupPosts;
using CSMWebsite2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages.Manage.GroupPosts
{
    public class Index : PageModel
    {
        public readonly IGroupPostService _grouppostService;

        public Index(IGroupPostService grouppostService)
        {
            _grouppostService = grouppostService;
        }
        public async Task OnGet(bool? isActive = true,  int? pageIndex = 1, int? pageSize = 10, string? keyword = "")
        {
            GroupPostItem = await _grouppostService.Posts(isActive, pageIndex, pageSize, keyword);
        }

        public Paged<GroupPostDto>? GroupPostItem { get; set; }

    }
}
