namespace CSMWebsite2023.Web.Pages.Manage.Researches
{
    public class Comment
    {
        public Guid? ResearchId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ReplyTold { get; set; }
        public Guid? Value { get; set; }
    }
}
