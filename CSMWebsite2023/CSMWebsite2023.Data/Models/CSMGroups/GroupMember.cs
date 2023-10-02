using CSMWebsite2023.Data.Models;

namespace CSMWebsite2023.Data.Models
{
    public class GroupMember : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? GroupId { get; set; }
        public Group? Group { get; set; }
        public string? Name { get; set; }
    }
}
