using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.Researches;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.Eventing.Reader;

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
        [BindProperty]
        public string? Error { get; set; }
        public async Task OnPost()
        {
            var op = await _researchService.Create(Dto);
            if(op != null && op.Status == OpStatus.Ok)
            {
                
            }
            else if(op != null && op.Status == OpStatus.Fail)
            {
                Error = op.Message;
            }
        }

    }
}
