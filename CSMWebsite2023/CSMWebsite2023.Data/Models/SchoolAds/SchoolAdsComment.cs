namespace CSMWebsite2023.Data.Models
{
    public class SchoolAdsComment : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? SchoolAdsId { get; set; }
        public SchoolAds? SchoolAds { get; set; }
        public Guid? ReplyToId { get; set; }
        public string? Message { get; set; }

    }
}
