namespace CSMWebsite2023.Data.Models
{
    public class AdShares : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? AdId { get; set; }
    }
}
