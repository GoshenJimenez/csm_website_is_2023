using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages.Manage.Researches
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
    public class Researches
    {
        public Guid? Media { get; set; }
        public Guid? Comment { get; set; }
        public Guid? Authors { get; set; }
        public Guid? Reactions { get; set; }
        public Guid? Shares { get; set; }
    }
}
