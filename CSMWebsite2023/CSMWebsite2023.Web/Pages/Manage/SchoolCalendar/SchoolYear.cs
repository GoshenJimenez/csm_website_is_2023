namespace CSMWebsite2023.Web.Pages.Manage.SchoolCalendar
{
    public class SchoolYear
    {
        public Guid? YearID { get; set; }
        public Guid? Month {  get; set; }
        public Guid? Day { get; set; }
        public Events?  Event {  get; set; }
        public Semesters? Semester { get; set; }
        public Holidays? Holiday { get; set; }
        public Exams? Exam { get; set; }
    }
}
