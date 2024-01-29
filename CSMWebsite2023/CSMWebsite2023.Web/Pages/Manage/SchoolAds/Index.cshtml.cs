using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.SchoolAds;
using CSMWebsite2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages.Manage.SchoolAds
{
    public class Index : PageModel
    {
        public readonly ISchoolAdService _schoolAdService;

        public Index(ISchoolAdService schoolAdService)
        {
            _schoolAdService = schoolAdService;
        }
        public async Task OnGet(bool? isActive = true,  int? pageIndex = 1, int? pageSize = 10, string? keyword = "")
        {
            SchoolAdItem = await _schoolAdService.Search(isActive, pageIndex, pageSize, keyword);
        }

        public Paged<SchoolAdDto>? SchoolAdItem { get; set; }

    }
}
