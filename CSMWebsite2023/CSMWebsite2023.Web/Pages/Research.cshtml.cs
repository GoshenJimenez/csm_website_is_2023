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
        public readonly ISchoolCalendarService _researchService;
        public Research(ISchoolCalendarService researchService)
        {
            _researchService = researchService;
        }

        public void OnGet(Guid? id = null)
        {
            //Chats = _chatService.GetChats();
            ResearchItem = _researchService.GetResearchById(id);
        }

        public SchoolCalendarDto? ResearchItem { get; set; }
    }
}