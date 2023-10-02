namespace CSMWebsite2023.Data.Models
{
    public class ResearchShare : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? ResearchId { get; set; }
        public Research? Research { get; set; }
    }
}
