using CSMWebsite2023.Contracts.ChatMessages;
using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Contracts.Researches;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;

namespace CSMWebsite2023.Web.Pages
{
    public class Research : PageModel
    {
        public readonly IResearchService _researchService;
        public Research(IResearchService researchService)
        {
            _researchService = researchService;
        }

        public void OnGet(Guid? id = null)
        {
            //Chats = _chatService.GetChats();
            ResearchItem = (ResearchDto?)_researchService.GetResearchById(id);

        }

        public ResearchDto? ResearchItem { get; set; }
    }
}