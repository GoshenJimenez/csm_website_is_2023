using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.Researches;
using CSMWebsite2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages.Manage.Researches
{
    public class Index : PageModel
    {
        public readonly IResearchService _researchService;

        public Index(IResearchService researchService)
        {
            _researchService = researchService;
        }
        public async Task OnGet(bool? isActive = true,  int? pageIndex = 1, int? pageSize = 10, string? keyword = "")
        {
            ResearchItem = await _researchService.Search(isActive, pageIndex, pageSize, keyword);
        }

        public Paged<ResearchDto>? ResearchItem { get; set; }

    }
}
