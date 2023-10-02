using CSMWebsite2023.Data.Models;

namespace CSMWebsite2023.Data.Models
{
    public class GroupPostReactions : BaseModel

    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? GroupId { get; set; }
        public Group? Group { get; set; }
        public Guid? GroupPostId { get; set; }
        public GroupPost? GroupPost { get; set; }
        public Guid? ReactionType { get; set; }
    }
}
