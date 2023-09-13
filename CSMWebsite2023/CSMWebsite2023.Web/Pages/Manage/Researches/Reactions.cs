namespace CSMWebsite2023.Web.Pages.Manage.Researches
{
    public class Reactions
    {
        public Guid? ResearchId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ReactionType { get; set; }
    }
    public class ReactionType
    {
        public Reactions? Like { get; set; }
        public Reactions? Love { get; set; }
        public Reactions? Care { get; set; }
        public Reactions? Haha { get; set; }
        public Reactions? Wow { get; set; }
        public Reactions? Sad { get; set; }
        public Reactions? Angry { get; set; }
    }
}
