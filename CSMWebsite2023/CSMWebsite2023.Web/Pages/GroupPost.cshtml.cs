using CSMWebsite2023.Contracts.ChatMessages;
using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Contracts.GroupPost;
using CSMWebsite2023.Contracts.SchoolPosts;
using CSMWebsite2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages
{
    public class GroupPost : PageModel
    {
        public readonly IGroupPostService _groupPostService;
        public GroupPost(IGroupPostService groupPostService)
        {
            _groupPostService = groupPostService;
        }

        public void OnGet(Guid? id = null)
        {
            //Chats = _chatService.GetChats();
            GroupPostItem = _groupPostService.GetGroupPostById(id);
        }

        public GroupPostDto? GroupPostItem { get; set; }
    }
}