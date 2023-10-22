using CSMWebsite2023.Contracts.Researches;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages.Manage.Researches
{
    public class Create : PageModel
    {
        public readonly IResearchService _researchService;
        public Create(IResearchService researchService)
        {
            _researchService = researchService;
            Dto = new CreateDto();
        }

        [BindProperty]
        public CreateDto? Dto { get; set; }
    }
}
