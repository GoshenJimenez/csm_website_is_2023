namespace CSMWebsite2023.Data.Models
{
    public class SchoolEventComment : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? SchoolEventId { get; set; }
        public SchoolEvent? SchoolEvent { get; set; }
        public Guid? ReplyToId { get; set; }
        public string? Value { get; set; }
    }
}
