using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages.Messages
{
    public class Index : PageModel
    {
        public readonly IChatService _chatService; 
        public Index(IChatService chatService) 
        { 
           _chatService = chatService;
        }

        public void OnGet()
        {
            Chats = _chatService.GetChats();
        }

        public List<ChatDto>? Chats { get; set; }
    }
}
