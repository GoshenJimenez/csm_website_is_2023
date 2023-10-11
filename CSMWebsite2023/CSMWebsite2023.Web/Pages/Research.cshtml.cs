using CSMWebsite2023.Contracts.ChatMessages;
using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Contracts.Researches;
using CSMWebsite2023.Contracts.SchoolPosts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
            ResearchItem = _researchService.GetResearchById(id);
        }

        public ResearchDto? ResearchItem { get; set; }
    }
}