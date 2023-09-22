using CSMWebsite2023.Contracts.ChatMessages;
using CSMWebsite2023.Contracts.Chats;

namespace CSMWebsite2023.Web.Pages.Manage.Researches
{
    public class Authors
    {
        public Guid? AuthorsId { get; set; }
        public Guid? ResearchId { get; set; }
        public string? Value { get; set; }
        public string? Name { get; set; }
    }
}
