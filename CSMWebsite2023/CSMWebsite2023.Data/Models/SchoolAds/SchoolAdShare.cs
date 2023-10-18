namespace CSMWebsite2023.Data.Models
{
    public class SchoolAdShare : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? SchoolAdsId { get; set; }
        public SchoolAd? SchoolAds { get; set; }
    }
}
