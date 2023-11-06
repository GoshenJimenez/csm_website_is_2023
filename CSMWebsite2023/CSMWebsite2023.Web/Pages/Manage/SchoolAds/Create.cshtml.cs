using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.SchoolAds;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.Eventing.Reader;

namespace CSMWebsite2023.Web.Pages.Manage.SchoolAds
{
    public class Create : PageModel
    {
        public readonly ISchoolAdService _schooladService;
        public Create(ISchoolAdService schooladService)
        {
            _schooladService = schooladService;
            Dto = new CreateDto();
        }

        [BindProperty]
        public CreateDto? Dto { get; set; }
        [BindProperty]
        public string? Error { get; set; }
        public async Task OnPost()
        {
            var op = await _schooladService.Create(Dto);
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
