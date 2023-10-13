using CSMWebsite2023.Data.Enums;

namespace CSMWebsite2023.Data.Models
{
    public class SchoolEventShare : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? SchoolEventId { get; set; }
        public SchoolEvent? SchoolEvent { get; set; }
    }
}

