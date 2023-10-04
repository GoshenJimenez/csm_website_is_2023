using CSMWebsite2023.Data.Enums;

namespace CSMWebsite2023.Data.Models
{
    public class AdReaction : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? SchoolAdId { get; set; }
        public SchoolAd? SchoolAd { get; set; }
        public ReactionType? ReactionType { get; set; }
    }
}
