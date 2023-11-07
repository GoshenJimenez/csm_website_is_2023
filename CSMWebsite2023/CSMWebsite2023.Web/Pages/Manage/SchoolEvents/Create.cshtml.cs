using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.SchoolEvents;
using CSMWebsite2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.Eventing.Reader;

namespace CSMWebsite2023.Web.Pages.Manage.SchoolEvents
{
    public class Create : PageModel
    {
        public readonly ISchoolEventService _schoolEventService;
        public Create(ISchoolEventService schoolEventService)
        {
            _schoolEventService = schoolEventService;
            Dto = new CreateDto();
        }

        [BindProperty]
        public CreateDto? Dto { get; set; }
        [BindProperty]
        public string? Error { get; set; }
        public async Task OnPost()
        {
            var op = await _schoolEventService.Create(Dto);
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
