using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.SchoolPosts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSMWebsite2023.Web.Pages.Manage.SchoolPosts
{
    public class Create : PageModel
    {
        public readonly ISchoolPostService _schoolPostService;
        public Create(ISchoolPostService schoolPostService)
        {
            _schoolPostService = schoolPostService;
            Dto = new CreateDto();
        }

        public async Task OnPost()
        {
            var op = await _schoolPostService.Create(Dto);
            if (op != null && op.Status == OpStatus.Ok)
            {

            }
            else if (op != null && op.Status == OpStatus.Fail)
            {
                Error = op.Message;
            }
        }

        [BindProperty]
        public CreateDto? Dto { get; set; }
        [BindProperty]
        public string? Error { get; set; }
    }
}
