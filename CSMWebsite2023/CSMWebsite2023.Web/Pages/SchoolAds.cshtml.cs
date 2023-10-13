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
        public readonly ISchoolAdsService _schooladsService;
        public SchoolAds(ISchoolAdsService schooladsService)
        {
            _schooladsService = schooladsService;
        }

        public void OnGet(Guid? id = null)
        {
            //Chats = _chatService.GetChats();
            SchoolAdsItem = _schooladsService.GetSchoolAdsById(id);
        }

        public SchoolAdsDto? SchoolAdsItem { get; set; }
    }
}