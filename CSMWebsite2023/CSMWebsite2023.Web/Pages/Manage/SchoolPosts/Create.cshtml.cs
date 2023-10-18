using CSMWebsite2023.Contracts.SchoolPosts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
            Dto.Id = Guid.NewGuid();
            var result = await _schoolPostService.Create(Dto);

            if(result == null) 
            {

            }
        }

        [BindProperty]
        public CreateDto? Dto { get; set; }
    }
}
