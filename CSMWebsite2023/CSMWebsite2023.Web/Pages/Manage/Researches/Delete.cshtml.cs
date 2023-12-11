using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.Researches;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SixLabors.ImageSharp.Processing;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Microsoft.Extensions.Hosting;

namespace CSMWebsite2023.Web.Pages.Manage.Researches
{
    public class Delete : PageModel
    {
        public readonly IResearchService _researchService;
        public readonly IWebHostEnvironment _env;
        public Delete(IResearchService researchService, IWebHostEnvironment env)
        {
            _researchService = researchService;
            Dto = new UpdateDto();
            _env = env;
        }

        public void OnGet(Guid? id = null)
        {
            //Chats = _chatService.GetChats();
            var record = _researchService.GetResearchById(id);

            if (record != null)
            {
                if (Dto == null)
                {
                    Dto = new UpdateDto();
                }
            }
        }

        public async Task OnPost()
        {
            if (Dto != null)
            {
                var op = await _researchService.Delete(
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