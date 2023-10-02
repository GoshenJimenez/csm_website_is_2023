namespace CSMWebsite2023.Data.Models
{
    public class AdComments : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? AdId { get; set; }
        public Guid? MediaType { get; set; }
        public string? Value {  get; set; }

    }
}
