namespace CSMWebsite2023.Web.Pages.Manage.SchoolCalendar
{
    public class SchoolYear
    {
        public Guid? YearID { get; set; }
        public Guid? Month {  get; set; }
        public Guid? Day { get; set; }
        public Events?  Event {  get; set; }
        public Semesters? Semesters { get; set; }
        public Holidays? Holidays { get; set; }
        public Exams? Exams { get; set; }
    }
}
