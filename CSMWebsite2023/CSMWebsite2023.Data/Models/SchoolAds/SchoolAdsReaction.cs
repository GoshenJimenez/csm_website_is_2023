using CSMWebsite2023.Data.Enums;

namespace CSMWebsite2023.Data.Models
{
    public class SchoolAdsReaction : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? SchoolAdsId { get; set; }
        public SchoolAds? SchoolAds { get; set; }
        public ReactionType? ReactionType { get; set; }
    }
}
