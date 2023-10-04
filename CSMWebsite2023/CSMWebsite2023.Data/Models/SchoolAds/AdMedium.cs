using CSMWebsite2023.Data.Enums;

namespace CSMWebsite2023.Data.Models
{
    public class AdMedium : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? SchoolAdId { get; set; }
        public SchoolAd? SchoolAd { get; set; }
        public MediaType? MediaType { get; set; }
        public string? Value { get; set; }


    }
}