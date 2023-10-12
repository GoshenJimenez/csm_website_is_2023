namespace CSMWebsite2023.Data.Models
{
    public class EventComment : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? EventId { get; set; }
        public Event? Event { get; set; }
        public Guid? ReplyToId { get; set; }
        public string? Value { get; set; }
    }
}
