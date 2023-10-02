namespace CSMWebsite2023.Data.Models
{
    public class GroupPostMedium : BaseModel
    {
        public Guid? GroupId { get; set; }
        public Group? Group { get; set; }
        public Guid? GroupPostId { get; set; }
        public GroupPost? GroupPost { get; set; }
        public Guid? MediaType { get; set; }
        public string? Value { get; set; }
    }
}
