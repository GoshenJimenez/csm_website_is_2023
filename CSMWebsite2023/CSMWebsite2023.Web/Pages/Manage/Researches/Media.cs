namespace CSMWebsite2023.Web.Pages.Manage.Researches
{
    public class Media
    {
        public Guid? ResearchId { get; set; }
        public Guid? Value { get; set; }

    }
    public class MediaType
    {
        public Media? Image { get; set; }
        public Media? Video { get; set; }
        public Media? Audio { get; set; }
        public Media? Text { get; set; }
        public Media? Html { get; set; }
    }
}
