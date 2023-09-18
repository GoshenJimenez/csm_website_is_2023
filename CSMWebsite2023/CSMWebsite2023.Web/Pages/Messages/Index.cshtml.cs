using CSMWebsite2023.Contracts.ChatMessages;
using CSMWebsite2023.Contracts.Chats;
using CSMWebsite2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages.Messages
{
    public class Index : PageModel
    {
        public readonly IChatService _chatService;
        public readonly IChatMessageService _chatMessageService;
        public Index(IChatService chatService, IChatMessageService chatMessageService) 
        { 
           _chatService = chatService;
            _chatMessageService = chatMessageService;
        }

        public void OnGet(Guid? id = null)
        {
            //Chats = _chatService.GetChats();
            ChatMessage = _chatMessageService.GetChatMessage(id);
        }

        public List<ChatDto>? Chats { get; set; }
        public ChatMessageDto? ChatMessage { get; set; }
    }
}
