using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.SchoolPosts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages.Manage.SchoolPosts
{
    public class Index : PageModel
    {
        public readonly ISchoolPostService _schoolPostService;

        public Index(ISchoolPostService schoolPostService)
        {
            _schoolPostService = schoolPostService;
        }
        public async Task OnGet(bool? isActive = true,  int? pageIndex = 1, int? pageSize = 10, string? keyword = "")
        {
            Posts = await _schoolPostService.Search(isActive, pageIndex, pageSize, keyword);
        }

        public Paged<SchoolPostDto>? Posts { get; set; }

    }
}
