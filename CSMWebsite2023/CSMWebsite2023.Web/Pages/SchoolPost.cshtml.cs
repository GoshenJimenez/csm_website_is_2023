using CSMWebsite2023.Contracts.ChatMessages;
using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Contracts.SchoolPosts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages
{
    public class SchoolPost : PageModel
    {
        public readonly ISchoolPostService _schoolPostService;
        public SchoolPost(ISchoolPostService schoolPostService)
        {
            _schoolPostService = schoolPostService;
        }

        public void OnGet(Guid? id = null)
        {
            //Chats = _chatService.GetChats();
            Post = _schoolPostService.GetSchoolPost(id);
        }

        public SchoolPostDto? Post { get; set; }
    }
}
