namespace CSMWebsite2023.Data.Models
{
    public class SchoolEvent : BaseModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
    }
}
