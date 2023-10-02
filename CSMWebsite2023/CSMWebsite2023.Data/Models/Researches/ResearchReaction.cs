using CSMWebsite2023.Data.Enums;

namespace CSMWebsite2023.Data.Models
{
    public class ResearchReaction : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? ResearchId { get; set; }
        public Research? Research { get; set; }
        public ReactionType? ReactionType { get; set; }

    }

}
