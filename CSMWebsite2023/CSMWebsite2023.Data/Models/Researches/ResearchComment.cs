namespace CSMWebsite2023.Data.Models
{
    public class ResearchComment : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? ResearchId { get; set; }
        public Research? Research { get; set; }
        public Guid? ReplyToId { get; set; }
        public string? Message { get; set; }
    }
}
