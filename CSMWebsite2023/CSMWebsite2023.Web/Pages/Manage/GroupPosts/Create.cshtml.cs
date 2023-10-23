using CSMWebsite2023.Contracts.GroupPosts;
using CSMWebsite2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages.Manage.GroupPosts
{
    public class Create : PageModel
    {
        public readonly IGroupPostService _groupPostService;
        public Create(IGroupPostService groupPostService)
        {
            _groupPostService = groupPostService;
            Dto = new CreateDto();
        }
        public async Task OnPost()
        {
            Dto.Id = Guid.NewGuid();
            var result = await _groupPostService.Create(Dto);

            if (result == null)
            {

            }
        }

        [BindProperty]
        public CreateDto? Dto { get; set; }
    }
}
