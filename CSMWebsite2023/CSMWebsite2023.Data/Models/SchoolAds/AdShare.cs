namespace CSMWebsite2023.Data.Models
{
    public class AdShare : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? SchoolAdId { get; set; }
        public SchoolAd? SchoolAd { get; set; }
    }
}
