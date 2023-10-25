using CSMWebsite2023.Contracts.GroupPosts;
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