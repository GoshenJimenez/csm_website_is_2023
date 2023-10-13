using CSMWebsite2023.Contracts.ChatMessages;
using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Contracts.GroupPost;
using CSMWebsite2023.Contracts.SchoolPosts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages
{
    public class GroupPost : PageModel
    {
        public readonly IGroupPostService _grouppostService;
        public GroupPost(IGroupPostService grouppostService)
        {
            _grouppostService = grouppostService;
        }

        public void OnGet(Guid? id = null)
        {
            //Chats = _chatService.GetChats();
            GroupPostItem = _grouppostService.GetGroupPostById(id);
        }

        public GroupPostDto? GroupPostItem { get; set; }
    }
}