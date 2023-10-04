namespace CSMWebsite2023.Data.Models
{
    public class AdComment : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? SchoolAdId { get; set; }
        public SchoolAd? SchoolAd { get; set; }
        public Guid? ReplyToId { get; set; }
        public string? Message { get; set; }

    }
}
