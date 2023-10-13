namespace CSMWebsite2023.Data.Models
{
    public class SchoolAdsShare : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? SchoolAdsId { get; set; }
        public SchoolAds? SchoolAds { get; set; }
    }
}
