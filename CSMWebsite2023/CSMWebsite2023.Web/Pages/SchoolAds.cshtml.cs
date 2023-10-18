using CSMWebsite2023.Contracts.ChatMessages;
using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Contracts.SchoolAds;
using CSMWebsite2023.Contracts.SchoolPosts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages
{
    public class SchoolAds : PageModel
    {
        public readonly ISchoolAdService _schoolAdService;
        public SchoolAds(ISchoolAdService schoolAdService)
        {
            _schoolAdService = schoolAdService;
        }

        public void OnGet(Guid? id = null)
        {
            //Chats = _chatService.GetChats();
            SchoolAdItem = _schoolAdService.GetSchoolAdById(id);
        }

        public SchoolAdDto? SchoolAdItem { get; set; }
    }
}