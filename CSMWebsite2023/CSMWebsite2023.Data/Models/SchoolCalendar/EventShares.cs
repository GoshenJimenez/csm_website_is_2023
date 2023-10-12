using CSMWebsite2023.Data.Enums;

namespace CSMWebsite2023.Data.Models
{
    public class EventShares : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? EventId { get; set; }
        public Event? Event { get; set; }
}
