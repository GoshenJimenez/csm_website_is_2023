namespace CSMWebsite2023.Data.Models
{
    public class GroupPost : BaseModel
    {
        public Guid? GroupId { get; set; }
        public Group? Group { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
