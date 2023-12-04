using CSMWebsite2023.Data.Enums;

namespace CSMWebsite2023.Data.Models
{
    public class ResearchMedium : BaseModel
    {
        public Guid? ResearchId { get; set; }
        public Research? Research { get; set; }
        public MediaType? MediaType { get; set; }
        public string? Value { get; set; }
    }
}
