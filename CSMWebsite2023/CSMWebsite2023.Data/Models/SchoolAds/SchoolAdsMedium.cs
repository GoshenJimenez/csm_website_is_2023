using CSMWebsite2023.Data.Enums;

namespace CSMWebsite2023.Data.Models
{
    public class SchoolAdsMedium : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? SchoolAdsId { get; set; }
        public SchoolAds? SchoolAds { get; set; }
        public MediaType? MediaType { get; set; }
        public string? Value { get; set; }


    }
}