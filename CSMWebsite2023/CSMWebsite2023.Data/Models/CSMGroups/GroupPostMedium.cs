using CSMWebsite2023.Data.Enums;

namespace CSMWebsite2023.Data.Models
{
    public class GroupPostMedium : BaseModel
    {
        public Guid? GroupId { get; set; }
        public Group? Group { get; set; }
        public Guid? GroupPostId { get; set; }
        public GroupPost? GroupPost { get; set; }
        public MediaType? MediaType { get; set; }
        public string? Value { get; set; }
    }
}
