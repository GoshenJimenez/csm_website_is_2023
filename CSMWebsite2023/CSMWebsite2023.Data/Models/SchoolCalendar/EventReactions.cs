namespace CSMWebsite2023.Data.Models
{
    public class EventReactions : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? EventId { get; set; }
        public Event? Event { get; set; }
        public Guid? ReactionType { get; set; }
    }
}
