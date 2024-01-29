using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.GroupPosts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SixLabors.ImageSharp.Processing;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Microsoft.Extensions.Hosting;

namespace CSMWebsite2023.Web.Pages.Manage.GroupPosts
{
    public class Restore : PageModel
    {
        public readonly IGroupPostService _grouppostService;
        public readonly IWebHostEnvironment _env;
        public Restore(IGroupPostService grouppostService, IWebHostEnvironment env)
        {
            _grouppostService = grouppostService;
            Dto = new UpdateDto();
            _env = env;
        }

        public void OnGet(Guid? id = null)
        {
            //Chats = _chatService.GetChats();
            var record = _grouppostService.GetGroupPostById(id);

            if(record != null)
            {
                if(Dto == null)
                {
                    Dto = new UpdateDto();
                }
            }
        }

        public async Task OnPost()
        {
            if (Dto != null)
            {
                var op = await _grouppostService.Restore(
                    new ActivationDto()
                    {
                        Id = Dto.Id,
                        IsActive = false
                    }
                );

                if (op != null && op.Status == OpStatus.Ok)
                {
                   
                }
                else if (op != null && op.Status == OpStatus.Fail)
                {
                    Error = op.Message;
                }
            }
        }

        [BindProperty]
        public UpdateDto? Dto { get; set; }

        [BindProperty]
        public string? Error { get; set; }
    }
}
