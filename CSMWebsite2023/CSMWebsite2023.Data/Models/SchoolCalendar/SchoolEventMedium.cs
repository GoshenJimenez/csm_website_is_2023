using CSMWebsite2023.Data.Enums;

namespace CSMWebsite2023.Data.Models
{
    public class SchoolEventMedium : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? SchoolEventId { get; set; }
        public SchoolEvent? SchoolEvent { get; set; }
        public MediaType? MediaType { get; set; }
        public string? Value { get; set; }

    }
}