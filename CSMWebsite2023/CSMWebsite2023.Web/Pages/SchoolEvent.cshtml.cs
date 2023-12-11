using CSMWebsite2023.Contracts.ChatMessages;
using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Contracts.SchoolEvents;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;

namespace CSMWebsite2023.Web.Pages
{
    public class SchoolEvent : PageModel
    {
        public readonly ISchoolEventService _schoolEventService;
        public SchoolEvent(ISchoolEventService schoolEventService)
        {
            _schoolEventService = schoolEventService;
        }

        public void OnGet(Guid? id = null)
        {
            //Chats = _chatService.GetChats();
            SchoolEventItem = _schoolEventService.GetSchoolEventById(id);
        }

        public SchoolEventDto? SchoolEventItem { get; set; }
    }
}
